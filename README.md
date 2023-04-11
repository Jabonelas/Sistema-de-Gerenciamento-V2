# Sistema-de-Gerenciamento-V2
Sistema de Gerenciamento - C# - SQL - Server


Sistema de gerenciamento V2 com áreas de faturamento, cadastro de clientes, fornecedores e funcionários, controle de estoque e financeiro com diferentes níveis de acessos por usuário.



**Tela de Login/Alertas: (Acesso Restrito)**

Verificação de acesso apenas por usuários. cadastrados

Alertas - Sendo exibido apenas para os usuários que possuem permissão.

Alerta de produtos com estoque baixo, podendo acessar a Tela de Estoque exibindo os produtos que estejam com o estoque baixo.

Alerta de contas atrasadas, podendo acessar a tela de Contas/Despesa exibindo as contas/despesas que estejam com o vencimento atrasados ou vencem no dia.

![enter image description here](https://i.imgur.com/8buGRxR.gif)


**Tela de Acesso Rapido:**

Acesso as principais funcionalidades do sistema.

Produto - Acesso a Novo Produto, Produtos Cadastrados, Estoque de Produtos.

Cadastros - Novo Cliente, Novo Fornecedor, Novo Funcionario, Cadastros.

Financeiro - Importar XML, Despesas/Contas, Categoria/Despesas.

Configurações - Dados da Empresa, Novo Usuario, Configurações Financeiras. 



![enter image description here](https://i.imgur.com/06txktr.png)

**Tela de PDV: (Acesso Restrito)**

 Mudança automática para exibição de Caixa Ocupado quando inicia a compra e para Caixa Disponível quando finaliza a compra.

 Inserção de produto por código de barras.

 Exibição de descrição de produto, valor por unidade, valor total, desconto.

**Atalhos:**

 F1: Buscar Produto por código.

 F2: Finalizar pagamento (Acesso a Tela de Pagamento).
 
 F3: Inserir Quantidade.
 
 F4: Inserir CPF/CNPJ com verificação de validação.
 
 F5: Buscar Produtos Cadastrados por código, descrição, grupo e sub-grupo ou marca.
  
 F6: Excluir item (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN)

 F9: Cancela Venda (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN)

 F12: Nova Venda.
 
 **- Tela de Pagamento:**
 
 Acesso aos tipo de pagamento e seus juros e descontos.
 
 **Atalhos:**
 
 Shift + D: Pagamento por dinheiro, calculando o desconto informando pelo ADMIN e calculando e exibindo o valor do troco.
 
 Shift + R: Pagamento por Debito, calculado o desconto informando pelo ADMIN.

 Shift + C: Pagamento por Credito, calculado o juros com base na quantidade de parcelas, ambos os valores é informando pelo ADMIN.
 
 Shift + P: Pagamento por Pix, calculado o desconto informando pelo ADMIN, exibindo do QRCode e Chave pix.

 F9: Cancela Venda (verifica se o usuário possui autorização, caso seja negativo solicita que seja liberado pelo ADMIN)

 F2: Finalizar pagamento (Impressão de Cupom Fiscal).


![enter image description here](https://i.imgur.com/0pRkaFi.gif)


**Tela de Visão Geral: (Acesso Restrito)**

Exibindo gráfico com os dados de despesa e venda mensal e semanal, sendo possível a seleção por ano e por mês.

Exibição do total de Despesas e Vendas Anuais e Semanais.

![enter image description here](https://i.imgur.com/nHD36O5.gif)


**Acesso aos Dados Financeiro: (Acesso Restrito)**

**- Importa XML:**

Importar XML para dar entrada de produtos no estoque, feita a verificação se a XML já existe no sistema, se o emissor,recepitor e produtos da XML possui cadastro no sistema, e se os valores dos produtos estão iguais aos cadastrados.

**- Despesa/Contas:**

Exibição de todas as despesas/contas cadastradas, o total em valor de contas atrasadas, aguardando pagamento e finalizadas.
Acesso ao Cadastro de novas Despesa/Contas, onde é possível indicar data de vencimento, valores, fornecedor, categoria, periodicidade e prazo.

**- Categoria/Despesa:**

Exibição de todas as categorias, custos e categorias agrupadoras.
Acesso ao cadastro de novas categorias, custos e categorias agrupadoras.

![enter image description here](https://i.imgur.com/vpmNyA9.gif)

**Tela de Cadastros: (Acesso Restrito)**

**- Cadastro de pessoa Física:**
 Cadastro de Cliente, Fornecedor e Funcionário - Com validação de RG, CPF, E-mail, CEP, preenchimento de dados de endereço com buscar por CEP e verifiração de idade não permitindo que menor de idade seja cadastrado.

**- Cadastro de pessoa Jurídica:** 
 Cadastro de Cliente, Fornecedor - Com validação de CNPJ, E-mail, preenchimento de dados de endereço com buscar por CEP  e verifiração de idade não permitindo que menor de idade seja cadastrado.


![enter image description here](https://i.imgur.com/dGCqzEb.gif)



**Tela de Produtos: (Acesso Restrito)**  
  
**- Cadastrar Novo Produto:**  
Sendo possível cadastrar seu estoque mínimo, porcentagem de lucro com exibição do preço já calculado em cima do valor de custo.  
Ao cadastrar o produto se o usuário não informar o seu código de barras o sistema gera automaticamente um código de barras valido.  
  
**- Consultar Produtos:**  
Exibição de todos os produtos cadastrados, com acesso a tele para cadastrar produto.  
  
**-Consultar Estoque:**  
Exibição de todos os produtos que estão disponíveis no estoque.

![enter image description here](https://i.imgur.com/cB3Rwl2.gif)

**Tela de Relatórios: (Acesso Restrito)**  
  
**- Histórico de Vendas:**  
  
Exibição do histórico de vendas com busca por data com informações do cliente, vendedor e valores e exibição do valor total do período.  
  
**- Indicadores de Vendas:**  
  
Exibindo de gráfico com os 5 produtos mais vendidos, e mais vendidos em quantidade ambos sendo possível realizar a busca por data.  
Exibição dos 5 produtos com maior margem de lucro em valor e maior margem média em porcentagem.  
  
**- Faturamento por Vendedor:**  
  
Exibição de vendas realizada, sendo possível realizar a busca por usuário e por data.  
Exibição de vendas realizada no dia, exibindo a quantidade total de produtos e o valor total, sendo possível realizar a busca por data.

![enter image description here](https://i.imgur.com/dFDxszD.gif)


**Configurações: (Acesso Restrito)**

**- Conf. Usuário:**

Acesso a todos os usuários cadastrados, a suas permissões de acesso, senha e acesso a cadastro de novos usuários.

**- Conf. Empresa:**

Acesso aos dados da empresa.

**- Conf. Perfil:**

Acesso aos dados do usuários que esta logado.

**- Conf. Financeira:**

Acesso as configurações financeiras, tais como porcentagem de desconto, juros, desconto por grupo de produtos, e quantidades parcelas para gerar juros.
Exibição de todos os produtos que estão com desconto.

![enter image description here](https://i.imgur.com/aK8Wkgw.gif)
