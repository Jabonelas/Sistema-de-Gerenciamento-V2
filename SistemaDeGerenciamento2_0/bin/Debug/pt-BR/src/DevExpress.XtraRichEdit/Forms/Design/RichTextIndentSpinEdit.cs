using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Mask;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Registrator;
using DevExpress.Utils;
using DevExpress.XtraRichEdit.Localization;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.Design;
using DevExpress.XtraRichEdit.Design.Internal;
using DevExpress.XtraRichEdit.Model;
using DevExpress.Office;
using DevExpress.Office.Design.Internal;


namespace DevExpress.XtraRichEdit.Design.Internal {
    public class RichTextIndentMaskManager : TextMaskManager {
        readonly RepositoryItemRichTextIndentEdit properties;
        readonly UIUnitConverter unitConverter;

        public RichTextIndentMaskManager(RepositoryItemRichTextIndentEdit properties, UIUnitConverter unitConverter) {
            Guard.ArgumentNotNull(properties, "properties");
            Guard.ArgumentNotNull(unitConverter, "unitConverter");
            this.properties = properties;
            this.unitConverter = unitConverter;
        }
        protected DocumentUnit DefaultMeasurementUnit {
            get { return properties.DefaultUnitType; }
        }
        public RepositoryItemRichTextIndentEdit Properties {
            get { return properties; }
        }
        protected bool IsValueInPercent {
            get { return properties.IsValueInPercent; }
        }
        protected override string GetDisplayText(string editText) {
            return RepositoryItemRichTextIndentEdit.TryMakePositiveDisplayText(base.GetDisplayText(editText), properties.DisplayValueAlwaysAsPositive);
        }
        public override bool SpinUp() {
            //UIUnit value = UIUnit.Create(CurrentState.EditText, DefaultMeasurementUnit, UnitPrecisionDictionary.DefaultPrecisions, IsValueInPercent);
            UIUnit value = unitConverter.CreateUIUnit(CurrentState.EditText, DefaultMeasurementUnit, IsValueInPercent);
            value++;
            if (Properties.IsWithinAllowedLimits(unitConverter.ToTwipsUnit(value, IsValueInPercent))) {
                Apply(value.ToString(), 0, 0, MaskManagerStateChangeType.Insert);
                return false;
            }
            return false;
        }
        public override bool SpinDown() {
            //UIUnit value = UIUnit.Create(CurrentState.EditText, DefaultMeasurementUnit, UnitPrecisionDictionary.DefaultPrecisions, IsValueInPercent);
            UIUnit value = unitConverter.CreateUIUnit(CurrentState.EditText, DefaultMeasurementUnit, IsValueInPercent);
            value--;
            if (Properties.IsWithinAllowedLimits(unitConverter.ToTwipsUnit(value, IsValueInPercent))) {
                Apply(value.ToString(), 0, 0, MaskManagerStateChangeType.Insert);
                return false;
            }
            return true;
        }
    }
}
namespace DevExpress.XtraRichEdit.Design {
    [DXToolboxItem(false)]
    public class RepositoryItemRichTextIndentEdit : RepositoryItemBaseSpinEdit {
        const int defaultMaxValue = +40000;
        const int defaultMinValue = -40000;
        const bool defaultDisplayValueAlwaysAsPositive = false;

        static RepositoryItemRichTextIndentEdit() {
            RegisterRichTextIndentEdit();
        }

        internal static string InternalEditorTypeName { get { return typeof(RichTextIndentEdit).Name; } }
        public static void RegisterRichTextIndentEdit() {
            //EditorClassInfo info = EditorRegistrationInfo.Default.Editors[InternalEditorTypeName];
            //if (info != null)
            //    EditorRegistrationInfo.Default.Editors.Remove(info);

            // TODO: replace image
            Bitmap img = ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraRichEdit.Bitmaps256.RichTextEdit.bmp", Assembly.GetExecutingAssembly());
            img.MakeTransparent(Color.Magenta);
            EditorClassInfo editorInfo = new EditorClassInfo(typeof(RichTextIndentEdit).Name, typeof(RichTextIndentEdit), typeof(RepositoryItemRichTextIndentEdit), typeof(DevExpress.XtraEditors.ViewInfo.BaseSpinEditViewInfo), new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true, img);
            editorInfo.AllowInplaceEditing = ShowInContainerDesigner.OnlyInBars;
            EditorRegistrationInfo.Default.Editors.Add(editorInfo);
        }

        DocumentUnit defaultUnitType;
        int maxValue;
        int minValue;
        int defaultValue;
        bool isValueInPercent;
        bool isUseValueInPercent;
        bool allowAssignExceedLimits;
        bool displayValueAlwaysAsPositive;

        public RepositoryItemRichTextIndentEdit() {
            Mask.MaskType = MaskType.Custom;
            this.defaultUnitType = DocumentUnit.Inch;
            this.maxValue = defaultMaxValue;
            this.minValue = defaultMinValue;
            CustomDisplayText += OnCustomDisplayText;
        }

        [Browsable(false)]
        public override HorzAlignment DefaultAlignment { get { return HorzAlignment.Near; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public new RepositoryItemRichTextIndentEdit Properties { get { return this; } }
        public bool IsValueInPercent {
            get {
                return isValueInPercent;
            }
            set {
                isValueInPercent = value;
                isUseValueInPercent |= value;
            }
        }
        public bool IsUseValueInPercent { get { return isUseValueInPercent; } }
        [Browsable(false)]
        public override string EditorTypeName { get { return InternalEditorTypeName; } }
        [DefaultValue(DocumentUnit.Inch)]
        public DocumentUnit DefaultUnitType {
            get { return defaultUnitType; }
            set {
                if (defaultUnitType == value)
                    return;
                defaultUnitType = value;
                OnPropertiesChanged();
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override MaskProperties Mask { get { return base.Mask; } }
        [DefaultValue(defaultMaxValue)]
        public int MaxValue {
            get { return maxValue; }
            set {
                if (MaxValue == value)
                    return;
                maxValue = value;
                OnPropertiesChanged();
            }
        }
        [DefaultValue(defaultMinValue)]
        public int MinValue {
            get { return minValue; }
            set {
                if (MinValue == value)
                    return;
                minValue = value;
                OnPropertiesChanged();
            }
        }
        [DefaultValue(0)]
        public int DefaultValue {
            get { return defaultValue; }
            set {
                if (defaultValue == value)
                    return;
                defaultValue = value;
                OnPropertiesChanged();
            }
        }
        [DefaultValue(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool AllowAssignExceedLimits {
            get { return allowAssignExceedLimits; }
            set {
                if (allowAssignExceedLimits == value)
                    return;
                allowAssignExceedLimits = value;
                OnPropertiesChanged();
            }
        }
        [DefaultValue(defaultDisplayValueAlwaysAsPositive), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool DisplayValueAlwaysAsPositive {
            get { return displayValueAlwaysAsPositive; }
            set {
                if (DisplayValueAlwaysAsPositive == value)
                    return;
                displayValueAlwaysAsPositive = value;
                OnPropertiesChanged();
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override FormatInfo DisplayFormat { get { return base.DisplayFormat; } }

        protected internal override MaskProperties CreateMaskProperties() {
            return new NumericMaskProperties();
        }
        protected internal override MaskManager CreateMaskManager(MaskProperties mask) {
            var indentEdit = OwnerEdit as RichTextIndentEdit;
            var unitConverter = indentEdit?.UIUnitConverter ?? new UIUnitConverter(UnitPrecisionDictionary.DefaultPrecisions);
            return new RichTextIndentMaskManager(this, unitConverter);
        }
        public override void Assign(RepositoryItem item) {
            RepositoryItemRichTextIndentEdit source = item as RepositoryItemRichTextIndentEdit;
            BeginUpdate();
            try {
                base.Assign(item);
                if (source == null) return;
                this.DefaultUnitType = source.DefaultUnitType;
                //this.IsValueInPercent = source.IsValueInPercent;
                this.MinValue = source.MinValue;
                this.MaxValue = source.MaxValue;
                this.DefaultValue = source.DefaultValue;
                this.AllowAssignExceedLimits = source.AllowAssignExceedLimits;
                this.DisplayValueAlwaysAsPositive = source.DisplayValueAlwaysAsPositive;
            }
            finally {
                EndUpdate();
            }
        }
        public bool IsWithinAllowedLimits(int value) {
            return value >= minValue && value <= maxValue;
        }
        public bool IsWithinAllowedLimits(string stringValue, DocumentUnit unitType, bool isValueInPercent, UIUnitConverter uiUnitConverter) {
            UIUnit unit = uiUnitConverter.CreateUIUnit(stringValue, unitType, isValueInPercent);
            int intValue = uiUnitConverter.ToTwipsUnit(unit, IsValueInPercent);
            return IsWithinAllowedLimits(intValue);
        }

        internal static string TryMakePositiveDisplayText(string displayText, bool displayValueAlwaysAsPositive) {
            if (displayValueAlwaysAsPositive) {
                if (!String.IsNullOrEmpty(displayText))
                    return displayText.TrimStart(' ', '-');
            }

            return displayText;
        }

        void OnCustomDisplayText(object sender, XtraEditors.Controls.CustomDisplayTextEventArgs e) {
            e.DisplayText = TryMakePositiveDisplayText(e.DisplayText, this.DisplayValueAlwaysAsPositive);
        }
    }
#if DEBUGTEST
    [DXToolboxItem(true)]
#else
    [DXToolboxItem(false)]
#endif // DEBUGTEST
    public class RichTextIndentEdit : BaseSpinEdit, IBatchUpdateable, IBatchUpdateHandler {
        static RichTextIndentEdit() {
            RepositoryItemRichTextIndentEdit.RegisterRichTextIndentEdit();
        }

        readonly BatchUpdateHelper batchUpdateHelper;
        readonly UIUnitConverter uiUnitConverter;
        bool deferredValueChanged;
        int? exactValue;
        DocumentModelUnitConverter valueUnitConverter;

        public RichTextIndentEdit() {
            this.batchUpdateHelper = new BatchUpdateHelper(this);
            this.uiUnitConverter = new UIUnitConverter(GetUnitPrecisions());
            this.valueUnitConverter = new DocumentModelUnitTwipsConverter();
            //EditValue = UIUnit.Create("0", DocumentUnit.Inch, UnitPrecisionDictionary.DefaultPrecisions); // ???
            EditValue = uiUnitConverter.CreateUIUnit("0", Properties.DefaultUnitType);
            this.exactValue = 0;
            SubscribeEvents();
        }

        protected internal virtual UnitPrecisionDictionary GetUnitPrecisions() {
            return UnitPrecisionDictionary.DefaultPrecisions;
        }

        [Browsable(false)]
        public override string EditorTypeName { get { return "RichTextIndentEdit"; } }
        [Category(CategoryName.Properties), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemRichTextIndentEdit Properties { get { return base.Properties as RepositoryItemRichTextIndentEdit; } }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override object EditValue { get { return base.EditValue; } set { base.EditValue = value; } }
        protected internal UIUnitConverter UIUnitConverter { get { return uiUnitConverter; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public DocumentModelUnitConverter ValueUnitConverter { get { return valueUnitConverter; } set { valueUnitConverter = value; } }
        protected internal bool IsValueInPercent { get { return Properties.IsValueInPercent; } }
        protected internal bool IsUseValueInPercent { get { return Properties.IsUseValueInPercent; } }

        protected internal float? CoreValue { // value in twips 
            get {
                string editValue = EditValue as String;
                if (editValue == null)
                    return 0;
                if (String.IsNullOrEmpty(editValue))
                    return null;
                //UIUnit unit = UIUnit.Create(editValue, Properties.DefaultUnitType, UnitPrecisionDictionary.DefaultPrecisions, IsValueInPercent);
                UIUnit unit = uiUnitConverter.CreateUIUnit(editValue, Properties.DefaultUnitType, IsValueInPercent);
                return uiUnitConverter.ToTwipsUnitF(unit, IsValueInPercent);
            }
            set {
                if (value == null) {
                    EditValue = String.Empty;
                    return;
                }
                float resultValue = value.Value;
                string stringEditValue = EditValue as String;
                //UIUnit oldUnit = UIUnit.Create(stringEditValue, Properties.DefaultUnitType, UnitPrecisionDictionary.DefaultPrecisions);
                UIUnit oldUnit = uiUnitConverter.CreateUIUnit(stringEditValue, Properties.DefaultUnitType);
                UIUnit unit = uiUnitConverter.ToUIUnitF(resultValue, oldUnit.UnitType, IsValueInPercent);
                if (!Properties.AllowAssignExceedLimits && !Properties.IsWithinAllowedLimits(uiUnitConverter.ToTwipsUnit(unit, IsValueInPercent))) {
                    unit = uiUnitConverter.ToUIUnit(Properties.MinValue, oldUnit.UnitType, IsValueInPercent);
                }
                if (!String.IsNullOrEmpty(stringEditValue) && oldUnit.Value == unit.Value && !IsUseValueInPercent)
                    return;
                EditValue = unit.ToString();
            }
        }
        [DefaultValue(0)]
        public virtual int? Value {
            get {
                if (exactValue.HasValue)
                    return exactValue;
                float? result = CoreValue;
                if (result == null)
                    return null;
                return ValueUnitConverter.TwipsToModelUnits((int)result.Value);
            }
            set {
                float? newValue = (value == null) ? ((float?)value) : (float?)ValueUnitConverter.ModelUnitsToTwipsF(value.Value);
                CoreValue = newValue;
                this.exactValue = value;
                if (!newValue.HasValue)
                    return;
                if (!Properties.AllowAssignExceedLimits && !Properties.IsWithinAllowedLimits((int)Math.Round(newValue.Value)))
                    this.exactValue = ValueUnitConverter.TwipsToModelUnits(Properties.MinValue);
            }
        }

        #region Events
        static readonly object onValueChanged = new object();
        public event EventHandler ValueChanged {
            add { Events.AddHandler(onValueChanged, value); }
            remove { Events.RemoveHandler(onValueChanged, value); }
        }
        void RaiseValueChanged() {
            EventHandler handler = (EventHandler)Events[onValueChanged];
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        #endregion

        protected internal override MaskManager CreateMaskManager(MaskProperties mask) {
            if (mask.MaskType == MaskType.Custom)
                return new RichTextIndentMaskManager(Properties, uiUnitConverter);
            else
                return base.CreateMaskManager(mask);
        }
        protected internal virtual void SubscribeEvents() {
            Validating += new CancelEventHandler(OnValidating);
        }
        protected internal virtual void UnsubscribeEvents() {
            Validating -= new CancelEventHandler(OnValidating);
        }
        protected override void OnSpin(DevExpress.XtraEditors.Controls.SpinEventArgs e) {
            this.exactValue = null;
            if (CoreValue != null && !Properties.IsWithinAllowedLimits((int)CoreValue.Value))
                CoreValue = Properties.DefaultValue;
            else
                base.OnSpin(e);
            DoValidate();
        }
        protected internal virtual void OnValidating(object sender, CancelEventArgs e) {
            e.Cancel = false;
            this.ErrorText = String.Empty;
            UIUnit result = null;

            string stringEditValue = EditValue as String;
            if (Properties.AllowNullInput == DefaultBoolean.True && String.IsNullOrEmpty(stringEditValue))
                return;
            if (Properties.AllowNullInput == DefaultBoolean.False && String.IsNullOrEmpty(stringEditValue)) {
                e.Cancel = true;
                ErrorText = GetInvalidValueRangeErrorMessage();
                return;
            }
            bool isValid = UIUnit.TryParse(stringEditValue, Properties.DefaultUnitType, out result, IsValueInPercent);
            if (!isValid) {
                e.Cancel = true;
                ErrorText = XtraRichEditLocalizer.GetString(XtraRichEditStringId.Msg_UsedWrongUnit);
                return;
            }
            if (!result.IsValidValue) {
                e.Cancel = true;
                ErrorText = XtraRichEditLocalizer.GetString(XtraRichEditStringId.Msg_InvalidNumber);
                return;
            }
            if (!Properties.IsWithinAllowedLimits(stringEditValue, result.UnitType, result.IsValueInPercent, UIUnitConverter)) {
                e.Cancel = true;
                ErrorText = GetInvalidValueRangeErrorMessage();
            }
        }
        protected internal virtual string GetInvalidValueRangeErrorMessage() {
            string stringFormat = XtraRichEditLocalizer.GetString(XtraRichEditStringId.Msg_InvalidValueRange);
            string minValue = uiUnitConverter.ToUIUnit(Properties.MinValue, Properties.DefaultUnitType, IsValueInPercent).ToString();
            string maxValue = uiUnitConverter.ToUIUnit(Properties.MaxValue, Properties.DefaultUnitType, IsValueInPercent).ToString();
            return String.Format(stringFormat, minValue, maxValue);
        }
        protected override void OnValidated(EventArgs e) {
            bool isModified = IsModified;
            base.OnValidated(e);
            if (isModified) {
                this.exactValue = null;
                OnValueChanged();
            }
        }
        protected virtual void OnValueChanged() {
            if (IsUpdateLocked)
                this.deferredValueChanged = true;
            else
                RaiseValueChanged();
        }

        #region IBatchUpdateable Members
        public BatchUpdateHelper BatchUpdateHelper { get { return batchUpdateHelper; } }
        public bool IsUpdateLocked { get { return batchUpdateHelper.IsUpdateLocked; } }
        new public void BeginUpdate() {
            base.BeginUpdate();
            BatchUpdateHelper.BeginUpdate();
        }
        new public void CancelUpdate() {
            base.CancelUpdate();
            BatchUpdateHelper.CancelUpdate();
        }
        new public void EndUpdate() {
            base.EndUpdate();
            BatchUpdateHelper.EndUpdate();
        }
        #endregion
        #region IBatchUpdateHandler Members
        void IBatchUpdateHandler.OnBeginUpdate() {
        }
        void IBatchUpdateHandler.OnCancelUpdate() {
        }
        void IBatchUpdateHandler.OnEndUpdate() {
        }
        void IBatchUpdateHandler.OnFirstBeginUpdate() {
            this.deferredValueChanged = false;
            UnsubscribeEvents();
        }
        void IBatchUpdateHandler.OnLastCancelUpdate() {
            SubscribeEvents();
        }
        void IBatchUpdateHandler.OnLastEndUpdate() {
            SubscribeEvents();
            if (this.deferredValueChanged)
                RaiseValueChanged();
        }
        #endregion
    }
}
