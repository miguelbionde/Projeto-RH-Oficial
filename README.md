# Projeto-RH-Oficial



 ## FUNÇÕES DO MENU DO PROGRAMA
  ### Função inicio ( )
 
    - Onde ela irá puxar a nossa funcao incio_menu() e aparecerá todas as opções dos nossos
      simuladores disponíveis para o usuário fazer sua escolha.
      
  ### Função inicio_menu ( )
  
    - Servirá como um retorno para a função inicio().
 
  ### Função menu ( )

    - Mostra as opções de simulador disponíveis para o usuário.
    
  ### Função seletor_programa ( )
 
    - Foi usado um escolha caso para selecionar a opção escolhida.
    
  ### Função volta_menu ( )

    - Função para que no fim de algum simulador o usuário tenha a opção de refaze-lo ou voltar para o menu.

 ## FUNÇÕES QUE FAZEM CALCULOS
 
 ### Função Calculo_Desconto_INSS ( )
 
    - Um simulador onde vai calcular qual o desconto de INSS
      (Instituto Nacional do Seguro Social)
      
 ### Função Calculo_Adicional_Ferias ( )
 
    - Onde calculo o valor a receber de férias, considerando o desconto do INSS e imposto de renda.
    
 ### Função Calculo_Imposto_de_Renda ( )

    - Nesta função é calculado o imposto de renda do colaborador.
    
 ### Função Calculo_Desconto_FGTS ( )

    - Função feita para facilitar a vida do usuário calculando automaticamente o FGTS
      (Fundo de Garantia do Tempo de Serviço).
     
 ### Função Calculo_Multa_FGTS ( )

    - Ele calculará a multa do FGTS.
    
 ### Função Calculo_Desconto_Vale_Transporte ( )

    - Nesta função o usuário simula o quanto o colaborador paga de vale transporte.
    
 ### Função Calculo_Adicional_Noturno ( )

    - Faz o calculo de quanto o funcionário vai receber nesse mês de adicional noturno.
    
 ### Função Calculo_Adicional_Periculosidade ( )

    - A função irá calcular quanto o empregado receberá neste mês de adicional de insalubridade.
    
 ### Função Calculo_Adicional_Horas_Extras ( )

    - Será calculada o valor dao adicional de horas extras deste mês.


 ## FUNÇÕES QUE RETORNAM OS CALCULOS
 
  ### Função Retorno_Calculo_Desconto_INSS ( )
 
    - É aonde o valor da função desconto_inss irá voltar o valor do desconto.
 
  ### Função Retorno_Calculo_Adicional_Ferias ( )
 
    - Função onde retornará o valor da função férias

  ### Função Retorno_Calculo_Imposto_de_Renda ( )
 
    - Ele retornará o valor da variável IR na função imposto de renda.

  ### Função Retorno_Calculo_Desconto_FGTS ( )

    - Retornando o valor da função FGTS na finalidade e evitar erros de repetição e para organização.

  ### Função Retorno_Calculo_Multa_FGTS ( ) 

    - Retorna o valor da variavel multa.
    
  ### Função Retorno_Calculo_Desconto_Vale_Transporte ( )

    - Retorna o valor de desconto_vale_trans, e diz se vale a pena ou não ultilizar este benefício.
 
  ### Função Retorno_Calculo_Adicional_Noturno ( )

    - Retorna o valor da variável valor_adicional_noturno.
    
  ### Função Retorno_Calculo_Adicional_Periculosidade ( )

    - Retorna o valor da variável valor_adicional_periculosidade.
    
  ### Função Retorno_Calculo_Adicional_Horas_Extras ( )

    - Retorna o valor da variável valor_adicional_horas_extras.  

 
 ## FUNÇÕES QUE FAZEM UMA SIMULAÇÃO
 
 ### Função Simulacao_Seguro_Desemprego ( )

    - Diz ao usuário se o colaborador tem ou não direito ao seguro desemprego.

 ### Função Simulacao_PIS ( )

    - Calcula se o empregado tem ou não direito ao pis se sim quanto receberá.

 ### Simulacao_Completa ( )

    - Faz a simulação do contra cheque do usuário, possuindo salário bruto, descontos, adicionais e 
      salário liquido.
      
 ## FUNÇÕES CASO A OPÇÃO ESCOLHIDA NÃO É COMPATIVEL
 
   (Se o usuário colocar uma opção não de acordo, o programa vai ficar repitindo
    até que coloque de forma correta.)
      
 ### Função Loop_Periculosidade ( )

    - É uma função para evitar que o usuário coloque alguma opção não compatível.
    
 ### Função Loop_Vale_Transporte ( )

    - É uma função para evitar que o usuário coloque alguma opção não compatível.


## FUNÇÕES QUE FAZEM O PROCESSO DE CADASTRAR UM FUNCIONÁRIO

 ### Função Cadastrar_Funcionarios ( )

    - Aqui o colaborador irá ser cadastradado e será arquivado no computador.
    
 ### Volta_Cadastro ( )

    - Pergunta ao cadastrador se ele deseja castrar um novo usuário.
_____________________________________________________________________________________________________________________________

## Referências Bibliográficas 

Aqui estão as pesquisas feitas nos sites referentes ao Projeto de RH!!

[Tabela do INSS - 2023](https://blog.convenia.com.br/tabela-do-inss-para-2023-confira-os-reajustes/)

[Como fazer calculo de férias - 2023](https://www.vagas.com.br/profissoes/como-calcular-ferias-calculo/#:~:text=No%20c%C3%A1lculo%20de%20f%C3%A9rias,%20%C3%A9,somar%201/3%20dele%20mesmo.)

[Tabela do Imposto de Renda - 2023](https://www.creditas.com/exponencial/tabela-imposto-de-renda/)

[Como fazer o calculo do valor a receber do FGTS - 2023](https://meutudo.com.br/blog/calculadoras/calculo-fgts/#:~:text=O%20c%C3%A1lculo%20mensal%20do%20FGTS,a%20antecipa%C3%A7%C3%A3o%20do%20recolhimento%20rescis%C3%B3rio%29.)

[Como calcular a multa de 40% do FGTS - 2023](https://economia.uol.com.br/noticias/redacao/2023/03/18/fgts-entenda-como-e-calculada-multa-de-40-em-caso-de-demissao.htm#:~:text=No%20caso%20da%20demiss%C3%A3o%20sem,de%20R$%2040.000,00.)

[Seguro - Desemprego - 2023 (Tudo o que você precisa saber!)](https://blog.pagseguro.uol.com.br/seguro-desemprego/)

[Como funciona o Vale-Transporte - 2023](https://www.bwg.com.br/como-funciona-o-vale-transporte/#:~:text=O%20uso%20do%20vale-transporte,profissional%20tenha%20direito%20ao%20custeio.)

[Quem tem direito ao PIS e como consultar - 2023](https://economia.uol.com.br/guia-de-economia/pis-como-consultar-o-seu-e-quem-tem-direito-ao-abono-salarial.htm)

[Tudo sobre o Adicional Noturno - 2023](https://www.gupy.io/blog/adicional-noturno#:~:text=Adicional%20noturno%20%C3%A9%20um%20acr%C3%A9scimo,22h%20at%C3%A9%205h%20da%20manh%C3%A3.)

[Tudo sobre o Adicional de Periculosidade - 2023](https://forbusiness.vagas.com.br/blog/adicional-de-periculosidade/#:~:text=periculosidade%20e%20insalubridade?-,O%20que%20%C3%A9%20adicional%20de%20periculosidade?,e%20gratifica%C3%A7%C3%B5es%20pagas%20pelo%20empregador.)

[Como fazer o calculo de horas extras - 2023](https://www.pontotel.com.br/como-calcular-hora-extra/#:~:text=E%20sobre%20o%20c%C3%A1lculo%20do,superior%20%C3%A0%20da%20hora%20normal.%E2%80%9D)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
