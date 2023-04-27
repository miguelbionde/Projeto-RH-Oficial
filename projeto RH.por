programa
{
	inclua biblioteca Texto--> txt
	inclua biblioteca Matematica --> mat
	inclua biblioteca Arquivos --> a
	inclua biblioteca ServicosWeb --> WS
	
	real Programa_Var_Salario_Bruto, Programa_Var_Horas_Extras, Programa_Var_Noturno, Programa_Var_Valor_Hora, Programa_Var_Hora_Trabalhada
	cadeia Programa_Var_Periculosidade, Programa_Var_Vale_Transporte
	funcao inicio()
	{
		escreva("           Ótimo Dia!\n")
		escreva("-> Quantas horas trabalhadas? ")
		leia(Programa_Var_Hora_Trabalhada)
		escreva("-> Qual o valor da hora trabalhada? ")
		leia(Programa_Var_Valor_Hora)
		Programa_Var_Salario_Bruto = Programa_Var_Valor_Hora * Programa_Var_Hora_Trabalhada
		escreva("-> Quantas horas extras? ")
		leia(Programa_Var_Horas_Extras)
		escreva("-> Quantas horas noturnas? ")
		leia(Programa_Var_Noturno)
		Loop_Insalubridade()
		
	}
	funcao Loop_Insalubridade()
	{
		escreva("-> Recebe adicional de periculosidade (S) ou (N)? ")
		leia(Programa_Var_Periculosidade)
		Programa_Var_Periculosidade = txt.caixa_alta(Programa_Var_Periculosidade)
		se(Programa_Var_Periculosidade != "S")
		{
			se(Programa_Var_Periculosidade != "N")
			{
				limpa()
				escreva("Coloque alguma das duas opções! (S) ou (N)\n")
				Loop_Insalubridade()
			}
			senao
			{
				Loop_Vale_Transporte()
			}
		}
		senao
		{
			Loop_Vale_Transporte()
		}
	}
	funcao Loop_Vale_Transporte()
	{
		escreva("-> Recebe vale transporte (S) ou (N)? ")
		leia(Programa_Var_Vale_Transporte)
		Programa_Var_Vale_Transporte = txt.caixa_alta(Programa_Var_Vale_Transporte)
		se(Programa_Var_Vale_Transporte != "S")
		{
			se(Programa_Var_Vale_Transporte != "N")
			{
				limpa()
				escreva("Coloque alguma das duas opções! (S) ou (N)\n")
				Loop_Vale_Transporte()
			}
			senao
			{
				inicio_menu()
			}
		}
		senao
		{
			inicio_menu()
		}
		
		
	}
	funcao inicio_menu()
	{	
		limpa()	
		menu()
		inteiro opcao_escolhida
		escreva("\nEscolha uma tarefa: ")
		leia(opcao_escolhida)
		seletor_programa(opcao_escolhida)
	}
	funcao menu()
	{
		escreva("SISTEMA DE RECURSOS HUMANOS")
		escreva("\n++++++++++++++++++++++++++++++++++++++++++++++++++++\n")
		escreva("+  1 - Simulador de Descontos do INSS              +\n")
		escreva("+  2 - Simulador de Cálculo de Férias              +\n")
		escreva("+  3 - Simulador de Descontos de Imposto de Renda  +\n")
		escreva("+  4 - Simulador de Benefícios de Deposito do FGTS +\n")
		escreva("+  5 - Simulador de Multa do FGTS                  +\n")
		escreva("+  6 - Simulador de Seguro-Desemprego		   +\n")
		escreva("+  7 - Simulador de Benefícios de Vale-Transporte  +\n")
		escreva("+  8 - Simulador de PIS				   +\n")
		escreva("+  9 - Simulador de Adicional Noturno		   +\n")
		escreva("+  10 - Simulador de Adicional por Periculosidade  +\n")
		escreva("+  11 - Simulador de Adicional de Horas Extras     +\n")
		escreva("+  12 - Contra Cheque				   +\n")
		escreva("+  13 - Cadastro de Funcionário                    +\n")
		escreva("+  14 - Sair do Sistema				   +")
		escreva("\n++++++++++++++++++++++++++++++++++++++++++++++++++++\n")
	}	
	funcao seletor_programa(inteiro opcao)
	{
		escolha(opcao)
		{
			caso 1:
				limpa()
				Retorno_Calculo_Desconto_INSS()
			pare
			caso 2:
				limpa()
				Retorno_Calculo_Adicional_Ferias()
			pare
			caso 3: 
				limpa()
				Retorno_Calculo_Imposto_de_Renda()
			pare
			caso 4:
				limpa()
				Retorno_Calculo_Desconto_FGTS()
			pare
			caso 5:
				limpa()
				Retorno_Calculo_Multa_FGTS()
			pare
			caso 6:
				limpa()
				Simulacao_Seguro_Desemprego()
			pare
			caso 7:
				limpa()
				Retorno_Calculo_Desconto_Vale_Transporte()
			pare
			caso 8: 
				limpa()
				Simulacao_PIS()
			pare
			caso 9:
				limpa()
				Retorno_Calculo_Adicional_Noturno()
			pare	
			caso 10:
				limpa()
				Retorno_Calculo_Adicional_Periculosidade()
			pare
			caso 11:
				limpa()
				Retorno_Calculo_Adicional_Horas_Extras()
			pare
			caso 12:
				limpa()
				Simulacao_Completa()
			pare
			caso 13:
				limpa()
				repetidor_cadastro()
			caso 14:
				limpa()
				escreva("Muito obrigado volte sempre!")
			pare	
			caso contrario :
				limpa()
				escreva("digite alguma opção existente!")
				inicio_menu()		
			pare	
		}	
	}
	funcao logico volta_menu()
	{
		caracter volta_menu_Var_Fechar_Programa
		logico volta_menu_Var_Validar_Escolha
		faca
		{	
			escreva("\n______________________________________________________________________\n")
			escreva("Deseja voltar ao menu? (s)Sim (n)Não\n")
			leia (volta_menu_Var_Fechar_Programa)
			se(volta_menu_Var_Fechar_Programa == 's' ou volta_menu_Var_Fechar_Programa == 'n')
			{
				volta_menu_Var_Validar_Escolha = falso
			}
			senao
			{
				volta_menu_Var_Validar_Escolha =  verdadeiro	
			}	
		}enquanto(volta_menu_Var_Validar_Escolha)
				
		se(volta_menu_Var_Fechar_Programa == 's')
		{
			retorne verdadeiro
		}
		senao
		{
			retorne falso
		}
	}
	funcao Retorno_Calculo_Desconto_INSS()
	{
		real Calculo_Desconto_INSS_Var_Salario_Bruto, Desconto_INSS
		escreva("_______________________________________________________________________\n")
	 	escreva("___________________Simulador de descontos do INSS______________________\n")
	 	escreva("\n\n")
	 	Calculo_Desconto_INSS_Var_Salario_Bruto = Programa_Var_Salario_Bruto
	 	Desconto_INSS = Calculo_Desconto_INSS(Calculo_Desconto_INSS_Var_Salario_Bruto)
	 	Desconto_INSS = mat.arredondar(Desconto_INSS, 2)
	 	escreva("Valor do desconto do INSS: R$", Desconto_INSS)

	 	logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Desconto_INSS()
		}
	}
	funcao real Calculo_Desconto_INSS(real Calculo_Desconto_INSS_Var_Salario_Bruto)
	{
		const real faixa_salarial = 1302.00
		const real faixa_salarial2 =2571.29
		const real faixa_salarial3 =3856.94
		real desconto_1, desconto_2, desconto_3, desconto_4

		se(Calculo_Desconto_INSS_Var_Salario_Bruto <= faixa_salarial)
		{
			desconto_1 = (Calculo_Desconto_INSS_Var_Salario_Bruto * 0.075)
			desconto_1 = mat.arredondar(desconto_1, 2)
			retorne desconto_1
		}
		senao se(Programa_Var_Salario_Bruto <= faixa_salarial2)
		{
			desconto_1 = (Calculo_Desconto_INSS_Var_Salario_Bruto * 0.075)
			desconto_2 = 0.09 * (Calculo_Desconto_INSS_Var_Salario_Bruto - faixa_salarial) + desconto_1
			desconto_2 = mat.arredondar(desconto_2, 2)
			retorne desconto_2
		}
		senao se(Programa_Var_Salario_Bruto <= faixa_salarial3)
		{
			desconto_1 = (Calculo_Desconto_INSS_Var_Salario_Bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (Calculo_Desconto_INSS_Var_Salario_Bruto - faixa_salarial2) + desconto_1 + desconto_2
			desconto_3 = mat.arredondar(desconto_3, 2)
			retorne desconto_3
		}	
		senao se(Programa_Var_Salario_Bruto >=  faixa_salarial3)
		{
			desconto_1 = (Calculo_Desconto_INSS_Var_Salario_Bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (faixa_salarial3 - faixa_salarial2)
			desconto_4 = 0.14 * (Calculo_Desconto_INSS_Var_Salario_Bruto - faixa_salarial3) +  desconto_1 + desconto_2 + desconto_3
			desconto_4 = mat.arredondar(desconto_4, 2)
			retorne desconto_4
		}
		retorne 0.0
	}
	funcao Retorno_Calculo_Adicional_Ferias()
	{
		real Adicional_Ferias, Calculo_Adicional_Ferias_Var_Salario_Bruto
		Calculo_Adicional_Ferias_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Adicional_Ferias = Calculo_Adicional_Ferias(Calculo_Adicional_Ferias_Var_Salario_Bruto)
		Adicional_Ferias = mat.arredondar(Adicional_Ferias, 2)
		escreva(Adicional_Ferias)
		
		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Adicional_Ferias()
		}
	}
	funcao real Calculo_Adicional_Ferias(real Calculo_Adicional_Ferias_Var_Salario_Bruto)
	{
		const real faixa_salarial = 1302.00
		const real faixa_salarial2 =2571.29
		const real faixa_salarial3 =3856.94
		real desconto_1, desconto_2, desconto_3, desconto_4
		inteiro dias_de_ferias
		real IR, valor_ferias, IR_ferias, IR_INSS, desconto_INSS = 0.0
		
		se(Programa_Var_Salario_Bruto < 2826.66)
		{
			IR = Programa_Var_Salario_Bruto * 0.075/3
		}
		senao se(Programa_Var_Salario_Bruto < 3751.06)
		{
			IR = Programa_Var_Salario_Bruto * 0.15/3
		}
		senao se(Programa_Var_Salario_Bruto < 4664.69)
		{
			IR = Programa_Var_Salario_Bruto * 0.225/3
		}
		senao
		{
			IR =Programa_Var_Salario_Bruto * 0.275/3
		}
		
		se(Programa_Var_Salario_Bruto <= faixa_salarial)
		{
			desconto_1 = (Programa_Var_Salario_Bruto * 0.075)/3
			desconto_INSS = desconto_1
		}
		senao se(Programa_Var_Salario_Bruto <= faixa_salarial2)
		{
			desconto_1 = (Programa_Var_Salario_Bruto * 0.075)
			desconto_2 = 0.09 * ((Programa_Var_Salario_Bruto - faixa_salarial) + desconto_1)/3
			desconto_INSS = desconto_2
		}
		senao se(Programa_Var_Salario_Bruto <= faixa_salarial3)
		{
			desconto_1 = (Programa_Var_Salario_Bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * ((Programa_Var_Salario_Bruto - faixa_salarial2) + desconto_1 + desconto_2)/3
			desconto_INSS = desconto_3
		}	
		senao se(Programa_Var_Salario_Bruto >=  faixa_salarial3)
		{
			desconto_1 = (Programa_Var_Salario_Bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (faixa_salarial3 - faixa_salarial2)
			desconto_4 = 0.14 * ((Programa_Var_Salario_Bruto - faixa_salarial3) +  desconto_1 + desconto_2 + desconto_3)/3
			desconto_INSS = desconto_4
		}

		IR_INSS = IR + desconto_INSS
		valor_ferias = Programa_Var_Salario_Bruto/3 - IR_INSS
		escreva("______________________________________________________________________\n")
		escreva("____________________Simulador de Adicional de Férias__________________\n")
		escreva("\nO colaborador receberá a mais R$ ")
		 valor_ferias= mat.arredondar(valor_ferias, 2)
		retorne valor_ferias
	}
	funcao Retorno_Calculo_Imposto_de_Renda()
	{
		real Calculo_Imposto_de_Renda_Var_Salario_Bruto, Desconto_Imposto_de_Renda
		Calculo_Imposto_de_Renda_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Desconto_Imposto_de_Renda = Calculo_Imposto_de_Renda(Calculo_Imposto_de_Renda_Var_Salario_Bruto)
		Desconto_Imposto_de_Renda = mat.arredondar(Desconto_Imposto_de_Renda, 2)
		escreva("_____________________________________________________________________\n")
		escreva("________________Simulador de Desconto de Imposto de Renda____________\n")
		escreva("\nValor do desconto do Imposto de Renda: R$", Desconto_Imposto_de_Renda)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Imposto_de_Renda()
		}
		
	}
	funcao real Calculo_Imposto_de_Renda(real Calculo_Imposto_de_Renda_Var_Salario_Bruto)
	{
		real IR
		se(Programa_Var_Salario_Bruto < 2826.66)
		{
			IR = Programa_Var_Salario_Bruto * 0.075
		}
		senao se(Programa_Var_Salario_Bruto < 3751.06)
		{
			IR = Programa_Var_Salario_Bruto * 0.15
		}
		senao se(Programa_Var_Salario_Bruto < 4664.69)
		{
			IR = Programa_Var_Salario_Bruto * 0.225
		}
		senao
		{
			IR =Programa_Var_Salario_Bruto * 0.275
		}
		IR = mat.arredondar(IR, 2)
		retorne IR
	}
	funcao Retorno_Calculo_Desconto_FGTS()
	{
		real Calculo_Desconto_FGTS_Var_Salario_Bruto, Desconto_FGTS
		Calculo_Desconto_FGTS_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Desconto_FGTS = Calculo_Desconto_FGTS(Calculo_Desconto_FGTS_Var_Salario_Bruto)
		Desconto_FGTS = mat.arredondar(Desconto_FGTS, 2)
		escreva("______________________________________________________________________\n")
		escreva("____________________Simulador de Desconto do FGTS_____________________\n")
		escreva("\nO desconto é de R$", Desconto_FGTS)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Desconto_FGTS()
		}
	}
	funcao real Calculo_Desconto_FGTS(real Calculo_Desconto_FGTS_Var_Salario_Bruto)
	{
		real fgts
		fgts = Programa_Var_Salario_Bruto * 0.08
		fgts = mat.arredondar(fgts, 2)
		retorne fgts
	}
	funcao Retorno_Calculo_Multa_FGTS()
	{
		real Calculo_Multa_FGTS_Var_Salario_Bruto, Calculo_Multa_FGTS_Var_Valor_Multa
		Calculo_Multa_FGTS_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Calculo_Multa_FGTS_Var_Valor_Multa = Calculo_Multa_FGTS(Calculo_Multa_FGTS_Var_Salario_Bruto)
		Calculo_Multa_FGTS_Var_Valor_Multa = mat.arredondar(Calculo_Multa_FGTS_Var_Valor_Multa, 2)
		
		escreva("\nO valor da multa é de R$", Calculo_Multa_FGTS_Var_Valor_Multa)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Multa_FGTS()
		}
	}
	funcao real Calculo_Multa_FGTS(real Calculo_Multa_FGTS_Var_Salario_Bruto)
	{
		real saldo, multa
		escreva("______________________________________________________________________\n")
		escreva("______________________Simulador de Multa de FGTS______________________\n")
		escreva("\nInforme o saldo da conta vinculada do FGTS na data de demissão: ")
		leia(saldo)
		multa = saldo * 0.4
		multa = mat.arredondar(multa, 2)
		retorne multa
	}
	funcao Simulacao_Seguro_Desemprego()
	{
		inteiro meses_trabalhados
		logico tem_direito

		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Seguro-Desemprego___________________\n")
		escreva("\nInforme a quantidade de meses trabalhados nos últimos 18 meses: ")
		leia(meses_trabalhados)

		se(meses_trabalhados >= 12 e meses_trabalhados <= 18)
		{
			tem_direito = verdadeiro
		}
		senao se(meses_trabalhados > 18)
		{
			tem_direito = verdadeiro
		}
		senao
		{
			tem_direito = falso
		}
		se(tem_direito)
		{
			escreva("Você tem direito ao Seguro-Desemprego!")
		}
		senao
		{
			escreva("Você ainda não tem direito ao Seguro-Desemprego!")
		}

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Simulacao_Seguro_Desemprego()
		}
	}
	funcao Retorno_Calculo_Desconto_Vale_Transporte()
	{
		real Calculo_Desconto_Vale_Transporte_Var_Desconto, Calculo_Desconto_Vale_Transporte_Var_Salario_Bruto
		cadeia simnao
		const real  passagem = 4.20
		
		Calculo_Desconto_Vale_Transporte_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Calculo_Desconto_Vale_Transporte_Var_Desconto = Calculo_Desconto_Vale_Transporte(Calculo_Desconto_Vale_Transporte_Var_Salario_Bruto)
		Calculo_Desconto_Vale_Transporte_Var_Desconto = mat.arredondar(Calculo_Desconto_Vale_Transporte_Var_Desconto, 2)
		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Vale-Transporte___________________\n")
		escreva("\nO valor de desconto de R$", Calculo_Desconto_Vale_Transporte_Var_Desconto, "\n")
		escreva("Gostaria que o sistema calcule e mostre se vale a pena ou não ele usar o benefício (S) ou (N)? ")
		leia(simnao)
		simnao = txt.caixa_alta(simnao)
		se(simnao == "S")
		{
			se(Calculo_Desconto_Vale_Transporte_Var_Desconto > 4 * passagem * 20)
			{
				escreva("Não vale a pena usar o benefício!\n")
			}
			senao
			{
				escreva("Vale a pena usar o benefício!\n")
			}
		}
		senao se(simnao == "N")
		{
			escreva("muito obrigado!")
		}
		senao
		{
			limpa()
			escreva("Coloque alguma das duas opções! (S) ou (N)\n")
			Retorno_Calculo_Desconto_Vale_Transporte()
		}
				
		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Desconto_Vale_Transporte()
		}	
	}
	funcao real Calculo_Desconto_Vale_Transporte(real Calculo_Desconto_Vale_Transporte_Var_Salario_Bruto)
	{
		const real porcentagem_desconto= 0.06
		real desconto_vale_trans
		
		desconto_vale_trans = Programa_Var_Salario_Bruto * porcentagem_desconto
		desconto_vale_trans = mat.arredondar(desconto_vale_trans, 2)
		retorne desconto_vale_trans
		
	}
	funcao Simulacao_PIS()
	{
		const real salario_minimo = 1.302
		real valor_pis
		inteiro meses_trabalhados

		escreva("______________________________________________________________________\n")
		escreva("____________________________Simulador de PIS__________________________\n")
		escreva("\nInforme a quantidade de meses trabalhados no ano-base: ")
		leia(meses_trabalhados)

		se(meses_trabalhados >= 12)
		{
			valor_pis = (salario_minimo * meses_trabalhados) / 12
			escreva("Você tem direito ao PIS!\n")
			escreva("O valor a ser recebido é de R$",valor_pis)
		}
		senao
		{
			escreva("Você ainda não tem direito ao PIS!")
		}

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Simulacao_PIS()
		}	
	}
	funcao Retorno_Calculo_Adicional_Noturno()
	{
		real Calculo_Adicional_Noturno_Var_Salario_Bruto, Adicional_Noturno
		Calculo_Adicional_Noturno_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Adicional_Noturno = Calculo_Adicional_Noturno(Calculo_Adicional_Noturno_Var_Salario_Bruto)
		Adicional_Noturno = mat.arredondar(Adicional_Noturno, 2)
		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Adicional Noturno___________________\n")
		escreva("\nO valor de adicional noturno é de R$",Adicional_Noturno)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Adicional_Noturno()
		}	
	}
	funcao real Calculo_Adicional_Noturno(real Calculo_Adicional_Noturno_Var_Salario_Bruto)
	{
		real salario_descontado, salario_hora, valor_adicional_noturno

		valor_adicional_noturno = ( Programa_Var_Valor_Hora * 0.2) * Programa_Var_Noturno
		salario_descontado = (Programa_Var_Salario_Bruto) + valor_adicional_noturno
		valor_adicional_noturno = mat.arredondar(valor_adicional_noturno, 2)
		retorne valor_adicional_noturno
	}
	funcao Retorno_Calculo_Adicional_Periculosidade()
	{
		real valor_adicional_periculosidade, Calculo_Adicional_Periculosidade_Var_salario_Bruto
		Calculo_Adicional_Periculosidade_Var_salario_Bruto = Programa_Var_Salario_Bruto
		valor_adicional_periculosidade = Calculo_Adicional_Periculosidade(Calculo_Adicional_Periculosidade_Var_salario_Bruto)
		valor_adicional_periculosidade = mat.arredondar(valor_adicional_periculosidade, 2)
		escreva("______________________________________________________________________\n")
		escreva("_______________Simulador de Adicional Por Periculosidade______________\n")
		escreva("\nO valor adicional de periculosidade é de R$", valor_adicional_periculosidade)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Adicional_Periculosidade()
		}	
	}
	funcao real Calculo_Adicional_Periculosidade(real Calculo_Adicional_Periculosidade_Var_salario_Bruto)
	{
		real valor_adicional_periculosidade
		valor_adicional_periculosidade = Programa_Var_Salario_Bruto * 0.3
		valor_adicional_periculosidade = mat.arredondar(valor_adicional_periculosidade, 2)
		retorne valor_adicional_periculosidade
	}
	funcao Retorno_Calculo_Adicional_Horas_Extras()
	{
		real Calculo_Adicional_Horas_Extras_Var_Salario_Bruto, Adicional_Horas_Extras
		Calculo_Adicional_Horas_Extras_Var_Salario_Bruto = Programa_Var_Salario_Bruto
		Adicional_Horas_Extras = Calculo_Adicional_Horas_Extras(Calculo_Adicional_Horas_Extras_Var_Salario_Bruto)
		escreva("______________________________________________________________________\n")
		escreva("___________________Simulador de Adicional Horas Extras________________\n")
		escreva("\nO valor adicional de horas extras é de R$",Adicional_Horas_Extras)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Retorno_Calculo_Adicional_Horas_Extras()
		}	
	}
	funcao real Calculo_Adicional_Horas_Extras(real Calculo_Adicional_Horas_Extras_Var_Salario_Bruto)
	{
		real valor_adicional_horas_extras

		valor_adicional_horas_extras = (Programa_Var_Valor_Hora * 1.5) * Programa_Var_Horas_Extras
		valor_adicional_horas_extras = mat.arredondar(valor_adicional_horas_extras, 2)
		retorne valor_adicional_horas_extras
	}
	funcao Simulacao_Completa()
	{
		limpa()
		real total_adionais, total_descontos, inss, salario_bruto_inss, salario_FGTS, fgts, desconto_vale_trans, salario_VT, IR, salario_IR, ad_noturno, salario_an, valor_adicional_periculosidade, salario_periculosidade, salario_hora_extra, ad_hora_extra, salario_liquido
		escreva("_________________________Simulação Completa____________________________\n")
		escreva("_______________________________________________________________________\n")
		escreva("Salário Bruto: R$", Programa_Var_Salario_Bruto)
		escreva("\nHoras extras: ", Programa_Var_Horas_Extras, " horas\n")
		escreva("Noturno: ", Programa_Var_Noturno, " horas \n")
		escreva("Periculosidade: ", Programa_Var_Periculosidade)
		escreva("\nVale transporte: ", Programa_Var_Vale_Transporte, "\n")
		
		escreva("\n_________________________Detalhamento________________________________\n")
		escreva("\nSalário base: R$", Programa_Var_Salario_Bruto)
		salario_hora_extra = Programa_Var_Salario_Bruto
		ad_hora_extra = Calculo_Adicional_Horas_Extras(salario_hora_extra)
		escreva("\nHoras extras: + R$", ad_hora_extra)
		salario_an = Programa_Var_Salario_Bruto
		ad_noturno = Calculo_Adicional_Noturno(salario_an)
		escreva("\nNoturno: + R$", ad_noturno)
		salario_periculosidade = Programa_Var_Salario_Bruto
		valor_adicional_periculosidade = Calculo_Adicional_Periculosidade(salario_periculosidade)
		se(Programa_Var_Periculosidade == "S")
		{
			escreva("\nPericulosidade: + R$", valor_adicional_periculosidade)
		}
		senao
		{
			valor_adicional_periculosidade = 0.00
			escreva("\nPericulosidade: + R$", valor_adicional_periculosidade)
		}		
		salario_FGTS = Programa_Var_Salario_Bruto
		fgts = Calculo_Desconto_FGTS(salario_FGTS)
		escreva("\nFGTS: + R$", fgts)
		salario_VT = Programa_Var_Salario_Bruto
		desconto_vale_trans = Calculo_Desconto_Vale_Transporte(salario_VT)
		se(Programa_Var_Vale_Transporte == "S")
		{
			escreva("\nVale transporte: - R$", desconto_vale_trans)
		}
		senao
		{
			desconto_vale_trans = 0.00
			escreva("\nVale transporte: - R$", desconto_vale_trans)
		}
		salario_bruto_inss = Programa_Var_Salario_Bruto
		inss = Calculo_Desconto_INSS(salario_bruto_inss)
		escreva("\nINSS: - R$", inss)
		salario_IR = Programa_Var_Salario_Bruto
		IR = Calculo_Imposto_de_Renda(salario_IR)
		escreva("\nImposto de Renda: - R$", IR)

		escreva("\n__________________________Resultado____________________________________\n")
		total_adionais = ad_hora_extra + valor_adicional_periculosidade + fgts + ad_noturno
		total_adionais = mat.arredondar(total_adionais, 2)
		escreva("\nTotal adicionais: R$", total_adionais)
		total_descontos = desconto_vale_trans + inss + IR
		total_descontos = mat.arredondar(total_descontos, 2)
		escreva("\nTotal descontos: R$", total_descontos)
		escreva("\n_______________________________________________________________________\n")
		salario_liquido = Programa_Var_Salario_Bruto + total_adionais - total_descontos
		salario_liquido = mat.arredondar(salario_liquido, 2)
		escreva("\nSalário líquito: R$", salario_liquido, "\n")

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			Simulacao_Completa()
		}		
	}
	funcao repetidor_cadastro()
	{
		cadeia telefone,email,cep,endereco,endereco_sem_cep,posicao,nome
		inteiro idade,caracteres
		logico verificar_se_existe_arquivo = a.arquivo_existe("/banco_dados.txt")
		
		para(inteiro i = 1; i <= 50;i++)
		{
			escreva("------------ CADASTRO DE FUNCIONÁRIO ----------\n")
			escreva("Digite seu nome completo: ")
			leia(nome)
			escreva("Digite sua idade: ")
			leia(idade)
			escreva("Digite seu email: ")
			leia(email)
			escreva("Digite seu telefone: ")
			leia(telefone)
			escreva("Digite seu CEP: ")
			leia(cep)
			endereco = WS.obter_dados("https://viacep.com.br/ws/"+ cep +"/json/")  //https://viacep.com.br/ws/29903087/json/
			caracteres = txt.numero_caracteres(endereco)
			endereco_sem_cep = txt.extrair_subtexto(endereco, 22 , caracteres)
			endereco_sem_cep = txt.substituir(endereco_sem_cep, "," , "\n")
		
		se(verificar_se_existe_arquivo == verdadeiro)
		{
			inteiro arquivo = a.abrir_arquivo("./banco_dados.txt", a.MODO_ACRESCENTAR)
			a.escrever_linha("FUNCIONÁRIO", arquivo)
			a.escrever_linha("NOME: " + txt.caixa_alta(nome),arquivo)
			a.escrever_linha("IDADE: " + idade, arquivo)
			a.escrever_linha("Email: " + txt.caixa_alta(email), arquivo)
			a.escrever_linha("Telefone: " + txt.caixa_alta(telefone), arquivo)
			a.escrever_linha("Endereço: " + txt.caixa_alta(endereco_sem_cep), arquivo)
			a.escrever_linha("\n", arquivo)
			a.fechar_arquivo(arquivo)
		}
		senao
		{
			inteiro arquivo = a.abrir_arquivo("./banco_dados.txt", a.MODO_ESCRITA)
			a.escrever_linha("FUNCIONÁRIO", arquivo)
			a.escrever_linha("NOME: " + txt.caixa_alta(nome), arquivo)
			a.escrever_linha("IDADE: " + idade, arquivo)
			a.escrever_linha("Email: " + txt.caixa_alta(email), arquivo)
			a.escrever_linha("Telefone: " + txt.caixa_alta(telefone), arquivo)
			a.escrever_linha("Endereço: " + txt.caixa_alta(endereco_sem_cep), arquivo)
			a.escrever_linha("\n", arquivo)
			a.fechar_arquivo(arquivo)
		}

		logico resultado = volta_cadastro()
		se(resultado)
		{
			limpa()
		}
		senao
		{
			inicio_menu()
		}
		}
	}
	funcao logico volta_cadastro()
	{
		cadeia opcao_usuario
		faca
		{
			escreva("Deseja cadastrar um novo usuário? (S/N)")
			leia(opcao_usuario)
			opcao_usuario = txt.caixa_alta(opcao_usuario)
		}
		enquanto(opcao_usuario != "S" e opcao_usuario != "N")

		se(opcao_usuario == "S")
		{
			retorne verdadeiro
		}
		senao
		{
			retorne falso
		}
	}
}
		
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 25851; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */