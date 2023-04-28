programa
{
	inclua biblioteca Texto--> txt
	inclua biblioteca Matematica --> mat
	inclua biblioteca Arquivos --> a
	inclua biblioteca ServicosWeb --> WS
	
	real programa_var_salario_bruto, programa_var_horas_extras, programa_var_noturno, programa_var_valor_hora, programa_var_hora_trabalhada
	cadeia programa_var_periculosidade, programa_var_vale_transporte
	funcao inicio()
	{
		escreva("           Ótimo Dia!\n")
		escreva("-> Quantas horas trabalhadas? ")
		leia(programa_var_hora_trabalhada)
		escreva("-> Qual o valor da hora trabalhada? ")
		leia(programa_var_valor_hora)
		programa_var_salario_bruto = programa_var_valor_hora * programa_var_hora_trabalhada
		escreva("-> Quantas horas extras? ")
		leia(programa_var_horas_extras)
		escreva("-> Quantas horas noturnas? ")
		leia(programa_var_noturno)
		loop_insalubridade()
		
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
	funcao logico volta_menu()
	{
		caracter volta_menu_var_fechar_programa
		logico volta_menu_var_validar_escolha
		faca
		{	
			escreva("\n______________________________________________________________________\n")
			escreva("Deseja voltar ao menu? (s)Sim (n)Não\n")
			leia (volta_menu_var_fechar_programa)
			se(volta_menu_var_fechar_programa == 's' ou volta_menu_var_fechar_programa == 'n')
			{
				volta_menu_var_validar_escolha = falso
			}
			senao
			{
				volta_menu_var_validar_escolha =  verdadeiro	
			}	
		}enquanto(volta_menu_var_validar_escolha)
				
		se(volta_menu_var_fechar_programa == 's')
		{
			retorne verdadeiro
		}
		senao
		{
			retorne falso
		}
	}
	funcao seletor_programa(inteiro opcao)
	{
		escolha(opcao)
		{
			caso 1:
				limpa()
				retorno_calculo_desconto_inss()
			pare
			caso 2:
				limpa()
				retorno_calculo_adicional_ferias()
			pare
			caso 3: 
				limpa()
				retorno_calculo_imposto_de_renda()
			pare
			caso 4:
				limpa()
				retorno_calculo_desconto_fgts()
			pare
			caso 5:
				limpa()
				retorno_calculo_multa_fgts()
			pare
			caso 6:
				limpa()
				simulacao_seguro_desemprego()
			pare
			caso 7:
				limpa()
				retorno_calculo_desconto_vale_transporte()
			pare
			caso 8: 
				limpa()
				simulacao_pis()
			pare
			caso 9:
				limpa()
				retorno_calculo_adicional_noturno()
			pare	
			caso 10:
				limpa()
				retorno_calculo_adicional_periculosidade()
			pare
			caso 11:
				limpa()
				retorno_calculo_adicional_horas_extras()
			pare
			caso 12:
				limpa()
				simulacao_completa()
			pare
			caso 13:
				limpa()
				cadastrar_funcionarios()
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
	funcao loop_insalubridade()
	{
		escreva("-> Recebe adicional de periculosidade (S) ou (N)? ")
		leia(programa_var_periculosidade)
		programa_var_periculosidade = txt.caixa_alta(programa_var_periculosidade)
		se(programa_var_periculosidade != "S")
		{
			se(programa_var_periculosidade != "N")
			{
				limpa()
				escreva("Coloque alguma das duas opções! (S) ou (N)\n")
				loop_insalubridade()
			}
			senao
			{
				loop_vale_transporte()
			}
		}
		senao
		{
			loop_vale_transporte()
		}
	}
	funcao loop_vale_transporte()
	{
		escreva("-> Recebe vale transporte (S) ou (N)? ")
		leia(programa_var_vale_transporte)
		programa_var_vale_transporte = txt.caixa_alta(programa_var_vale_transporte)
		se(programa_var_vale_transporte != "S")
		{
			se(programa_var_vale_transporte != "N")
			{
				limpa()
				escreva("Coloque alguma das duas opções! (S) ou (N)\n")
				loop_vale_transporte()
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
	funcao retorno_calculo_desconto_inss()
	{
		real calculo_desconto_inss_var_salario_bruto, desconto_inss
		escreva("_______________________________________________________________________\n")
	 	escreva("___________________Simulador de descontos do INSS______________________\n")
	 	escreva("\n\n")
	 	calculo_desconto_inss_var_salario_bruto = programa_var_salario_bruto
	 	desconto_inss = calculo_desconto_inss(calculo_desconto_inss_var_salario_bruto)
	 	desconto_inss = mat.arredondar(desconto_inss, 2)
	 	escreva("Valor do desconto do INSS: R$", desconto_inss)

	 	logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_desconto_inss()
		}
	}
	funcao real calculo_desconto_inss(real calculo_desconto_inss_var_salario_bruto)
	{
		const real faixa_salarial = 1302.00
		const real faixa_salarial2 =2571.29
		const real faixa_salarial3 =3856.94
		real desconto_1, desconto_2, desconto_3, desconto_4

		se(calculo_desconto_inss_var_salario_bruto <= faixa_salarial)
		{
			desconto_1 = (calculo_desconto_inss_var_salario_bruto * 0.075)
			desconto_1 = mat.arredondar(desconto_1, 2)
			retorne desconto_1
		}
		senao se(programa_var_salario_bruto <= faixa_salarial2)
		{
			desconto_1 = (calculo_desconto_inss_var_salario_bruto * 0.075)
			desconto_2 = 0.09 * (calculo_desconto_inss_var_salario_bruto - faixa_salarial) + desconto_1
			desconto_2 = mat.arredondar(desconto_2, 2)
			retorne desconto_2
		}
		senao se(programa_var_salario_bruto <= faixa_salarial3)
		{
			desconto_1 = (calculo_desconto_inss_var_salario_bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (calculo_desconto_inss_var_salario_bruto - faixa_salarial2) + desconto_1 + desconto_2
			desconto_3 = mat.arredondar(desconto_3, 2)
			retorne desconto_3
		}	
		senao se(programa_var_salario_bruto >=  faixa_salarial3)
		{
			desconto_1 = (calculo_desconto_inss_var_salario_bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (faixa_salarial3 - faixa_salarial2)
			desconto_4 = 0.14 * (calculo_desconto_inss_var_salario_bruto - faixa_salarial3) +  desconto_1 + desconto_2 + desconto_3
			desconto_4 = mat.arredondar(desconto_4, 2)
			retorne desconto_4
		}
		retorne 0.0
	}
	funcao retorno_calculo_adicional_ferias()
	{
		real adicional_ferias, calculo_adicional_ferias_var_salario_bruto
		calculo_adicional_ferias_var_salario_bruto = programa_var_salario_bruto
		adicional_ferias = calculo_adicional_ferias(calculo_adicional_ferias_var_salario_bruto)
		adicional_ferias = mat.arredondar(adicional_ferias, 2)
		escreva(adicional_ferias)
		
		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_adicional_ferias()
		}
	}
	funcao real calculo_adicional_ferias(real calculo_adicional_ferias_var_salario_bruto)
	{
		const real faixa_salarial = 1302.00
		const real faixa_salarial2 =2571.29
		const real faixa_salarial3 =3856.94
		real desconto_1, desconto_2, desconto_3, desconto_4
		inteiro dias_de_ferias
		real ir, valor_ferias, ir_ferias, ir_inss, desconto_inss = 0.0
		
		se(programa_var_salario_bruto < 2826.66)
		{
			ir = programa_var_salario_bruto * 0.075/3
		}
		senao se(programa_var_salario_bruto < 3751.06)
		{
			ir = programa_var_salario_bruto * 0.15/3
		}
		senao se(programa_var_salario_bruto < 4664.69)
		{
			ir = programa_var_salario_bruto * 0.225/3
		}
		senao
		{
			ir =programa_var_salario_bruto * 0.275/3
		}
		
		se(programa_var_salario_bruto <= faixa_salarial)
		{
			desconto_1 = (programa_var_salario_bruto * 0.075)/3
			desconto_inss = desconto_1
		}
		senao se(programa_var_salario_bruto <= faixa_salarial2)
		{
			desconto_1 = (programa_var_salario_bruto * 0.075)
			desconto_2 = 0.09 * ((programa_var_salario_bruto - faixa_salarial) + desconto_1)/3
			desconto_inss = desconto_2
		}
		senao se(programa_var_salario_bruto <= faixa_salarial3)
		{
			desconto_1 = (programa_var_salario_bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * ((programa_var_salario_bruto - faixa_salarial2) + desconto_1 + desconto_2)/3
			desconto_inss = desconto_3
		}	
		senao se(programa_var_salario_bruto >=  faixa_salarial3)
		{
			desconto_1 = (programa_var_salario_bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (faixa_salarial3 - faixa_salarial2)
			desconto_4 = 0.14 * ((programa_var_salario_bruto - faixa_salarial3) +  desconto_1 + desconto_2 + desconto_3)/3
			desconto_inss = desconto_4
		}

		ir_inss = ir + desconto_inss
		valor_ferias = programa_var_salario_bruto/3 - ir_inss
		escreva("______________________________________________________________________\n")
		escreva("____________________Simulador de Adicional de Férias__________________\n")
		escreva("\nO colaborador receberá a mais R$ ")
		 valor_ferias= mat.arredondar(valor_ferias, 2)
		retorne valor_ferias
	}
	funcao retorno_calculo_imposto_de_renda()
	{
		real calculo_imposto_de_renda_var_salario_bruto, desconto_imposto_de_renda
		calculo_imposto_de_renda_var_salario_bruto = programa_var_salario_bruto
		desconto_imposto_de_renda = calculo_imposto_de_renda(calculo_imposto_de_renda_var_salario_bruto)
		desconto_imposto_de_renda = mat.arredondar(desconto_imposto_de_renda, 2)
		escreva("_____________________________________________________________________\n")
		escreva("________________Simulador de Desconto de Imposto de Renda____________\n")
		escreva("\nValor do desconto do Imposto de Renda: R$", desconto_imposto_de_renda)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_imposto_de_renda()
		}
		
	}
	funcao real calculo_imposto_de_renda(real calculo_imposto_de_renda_var_salario_bruto)
	{
		real ir
		se(programa_var_salario_bruto < 2826.66)
		{
			ir = programa_var_salario_bruto * 0.075
		}
		senao se(programa_var_salario_bruto < 3751.06)
		{
			ir = programa_var_salario_bruto * 0.15
		}
		senao se(programa_var_salario_bruto < 4664.69)
		{
			ir = programa_var_salario_bruto * 0.225
		}
		senao
		{
			ir =programa_var_salario_bruto * 0.275
		}
		ir = mat.arredondar(ir, 2)
		retorne ir
	}
	funcao retorno_calculo_desconto_fgts()
	{
		real calculo_desconto_fgts_var_salario_bruto, desconto_fgts
		calculo_desconto_fgts_var_salario_bruto = programa_var_salario_bruto
		desconto_fgts = calculo_desconto_fgts(calculo_desconto_fgts_var_salario_bruto)
		desconto_fgts = mat.arredondar(desconto_fgts, 2)
		escreva("______________________________________________________________________\n")
		escreva("____________________Simulador de Desconto do FGTS_____________________\n")
		escreva("\nO desconto é de R$", desconto_fgts)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_desconto_fgts()
		}
	}
	funcao real calculo_desconto_fgts(real calculo_desconto_fgts_var_salario_bruto)
	{
		real fgts
		fgts = programa_var_salario_bruto * 0.08
		fgts = mat.arredondar(fgts, 2)
		retorne fgts
	}
	funcao retorno_calculo_multa_fgts()
	{
		real calculo_multa_fgts_var_salario_bruto, calculo_multa_fgts_var_valor_multa
		calculo_multa_fgts_var_salario_bruto = programa_var_salario_bruto
		calculo_multa_fgts_var_valor_multa = calculo_multa_fgts(calculo_multa_fgts_var_salario_bruto)
		calculo_multa_fgts_var_valor_multa = mat.arredondar(calculo_multa_fgts_var_valor_multa, 2)
		
		escreva("\nO valor da multa é de R$", calculo_multa_fgts_var_valor_multa)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_multa_fgts()
		}
	}
	funcao real calculo_multa_fgts(real calculo_multa_fgts_var_salario_bruto)
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
	funcao simulacao_seguro_desemprego()
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
			simulacao_seguro_desemprego()
		}
	}
	funcao retorno_calculo_desconto_vale_transporte()
	{
		real calculo_desconto_vale_transporte_var_desconto, calculo_desconto_vale_transporte_var_salario_bruto
		cadeia sim_nao
		const real  passagem = 4.20
		
		calculo_desconto_vale_transporte_var_salario_bruto = programa_var_salario_bruto
		calculo_desconto_vale_transporte_var_desconto = calculo_desconto_vale_transporte(calculo_desconto_vale_transporte_var_salario_bruto)
		calculo_desconto_vale_transporte_var_desconto = mat.arredondar(calculo_desconto_vale_transporte_var_desconto, 2)
		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Vale-Transporte___________________\n")
		escreva("\nO valor de desconto de R$", calculo_desconto_vale_transporte_var_desconto, "\n")
		escreva("Gostaria que o sistema calcule e mostre se vale a pena ou não ele usar o benefício (S) ou (N)? ")
		leia(sim_nao)
		sim_nao = txt.caixa_alta(sim_nao)
		se(sim_nao == "S")
		{
			se(calculo_desconto_vale_transporte_var_desconto > 4 * passagem * 20)
			{
				escreva("Não vale a pena usar o benefício!\n")
			}
			senao
			{
				escreva("Vale a pena usar o benefício!\n")
			}
		}
		senao se(sim_nao == "N")
		{
			escreva("muito obrigado!")
		}
		senao
		{
			limpa()
			escreva("Coloque alguma das duas opções! (S) ou (N)\n")
			retorno_calculo_desconto_vale_transporte()
		}
				
		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_desconto_vale_transporte()
		}	
	}
	funcao real calculo_desconto_vale_transporte(real calculo_desconto_vale_transporte_var_salario_bruto)
	{
		const real porcentagem_desconto= 0.06
		real desconto_vale_trans
		
		desconto_vale_trans = programa_var_salario_bruto * porcentagem_desconto
		desconto_vale_trans = mat.arredondar(desconto_vale_trans, 2)
		retorne desconto_vale_trans
		
	}
	funcao simulacao_pis()
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
			simulacao_pis()
		}	
	}
	funcao retorno_calculo_adicional_noturno()
	{
		real calculo_adicional_noturno_var_salario_bruto, adicional_noturno
		calculo_adicional_noturno_var_salario_bruto = programa_var_salario_bruto
		adicional_noturno = calculo_adicional_noturno(calculo_adicional_noturno_var_salario_bruto)
		adicional_noturno = mat.arredondar(adicional_noturno, 2)
		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Adicional Noturno___________________\n")
		escreva("\nO valor de adicional noturno é de R$",adicional_noturno)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_adicional_noturno()
		}	
	}
	funcao real calculo_adicional_noturno(real calculo_adicional_noturno_var_salario_bruto)
	{
		real salario_descontado, salario_hora, valor_adicional_noturno

		valor_adicional_noturno = ( programa_var_valor_hora * 0.2) * programa_var_noturno
		salario_descontado = (programa_var_salario_bruto) + valor_adicional_noturno
		valor_adicional_noturno = mat.arredondar(valor_adicional_noturno, 2)
		retorne valor_adicional_noturno
	}
	funcao retorno_calculo_adicional_periculosidade()
	{
		real valor_adicional_periculosidade, calculo_adicional_periculosidade_var_salario_bruto
		calculo_adicional_periculosidade_var_salario_bruto = programa_var_salario_bruto
		valor_adicional_periculosidade = calculo_adicional_periculosidade(calculo_adicional_periculosidade_var_salario_bruto)
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
			retorno_calculo_adicional_periculosidade()
		}	
	}
	funcao real calculo_adicional_periculosidade(real calculo_adicional_periculosidade_var_salario_bruto)
	{
		real valor_adicional_periculosidade
		valor_adicional_periculosidade = programa_var_salario_bruto * 0.3
		valor_adicional_periculosidade = mat.arredondar(valor_adicional_periculosidade, 2)
		retorne valor_adicional_periculosidade
	}
	funcao retorno_calculo_adicional_horas_extras()
	{
		real calculo_adicional_horas_extras_var_salario_bruto, adicional_horas_extras
		calculo_adicional_horas_extras_var_salario_bruto = programa_var_salario_bruto
		adicional_horas_extras = calculo_adicional_horas_extras(calculo_adicional_horas_extras_var_salario_bruto)
		escreva("______________________________________________________________________\n")
		escreva("___________________Simulador de Adicional Horas Extras________________\n")
		escreva("\nO valor adicional de horas extras é de R$",adicional_horas_extras)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_calculo_adicional_horas_extras()
		}	
	}
	funcao real calculo_adicional_horas_extras(real calculo_adicional_horas_extras_var_salario_bruto)
	{
		real valor_adicional_horas_extras

		valor_adicional_horas_extras = (programa_var_valor_hora * 1.5) * programa_var_horas_extras
		valor_adicional_horas_extras = mat.arredondar(valor_adicional_horas_extras, 2)
		retorne valor_adicional_horas_extras
	}
	funcao simulacao_completa()
	{
		limpa()
		real total_adionais, total_descontos, inss, salario_bruto_inss, salario_fgts, fgts, desconto_vale_trans, salario_vt, ir, salario_ir, ad_noturno, salario_an, valor_adicional_periculosidade, salario_periculosidade, salario_hora_extra, ad_hora_extra, salario_liquido
		escreva("_________________________Simulação Completa____________________________\n")
		escreva("_______________________________________________________________________\n")
		escreva("Salário Bruto: R$", programa_var_salario_bruto)
		escreva("\nHoras extras: ", programa_var_horas_extras, " horas\n")
		escreva("Noturno: ", programa_var_noturno, " horas \n")
		escreva("Periculosidade: ", programa_var_periculosidade)
		escreva("\nVale transporte: ", programa_var_vale_transporte, "\n")
		
		escreva("\n_________________________Detalhamento________________________________\n")
		escreva("\nSalário base: R$", programa_var_salario_bruto)
		salario_hora_extra = programa_var_salario_bruto
		ad_hora_extra = calculo_adicional_horas_extras(salario_hora_extra)
		escreva("\nHoras extras: + R$", ad_hora_extra)
		salario_an = programa_var_salario_bruto
		ad_noturno = calculo_adicional_noturno(salario_an)
		escreva("\nNoturno: + R$", ad_noturno)
		salario_periculosidade = programa_var_salario_bruto
		valor_adicional_periculosidade = calculo_adicional_periculosidade(salario_periculosidade)
		se(programa_var_periculosidade == "S")
		{
			escreva("\nPericulosidade: + R$", valor_adicional_periculosidade)
		}
		senao
		{
			valor_adicional_periculosidade = 0.00
			escreva("\nPericulosidade: + R$", valor_adicional_periculosidade)
		}		
		salario_fgts = programa_var_salario_bruto
		fgts = calculo_desconto_fgts(salario_fgts)
		escreva("\nFGTS: + R$", fgts)
		salario_vt = programa_var_salario_bruto
		desconto_vale_trans = calculo_desconto_vale_transporte(salario_vt)
		se(programa_var_vale_transporte == "S")
		{
			escreva("\nVale transporte: - R$", desconto_vale_trans)
		}
		senao
		{
			desconto_vale_trans = 0.00
			escreva("\nVale transporte: - R$", desconto_vale_trans)
		}
		salario_bruto_inss = programa_var_salario_bruto
		inss = calculo_desconto_inss(salario_bruto_inss)
		escreva("\nINSS: - R$", inss)
		salario_ir = programa_var_salario_bruto
		ir = calculo_imposto_de_renda(salario_ir)
		escreva("\nImposto de Renda: - R$", ir)

		escreva("\n__________________________Resultado____________________________________\n")
		total_adionais = ad_hora_extra + valor_adicional_periculosidade + fgts + ad_noturno
		total_adionais = mat.arredondar(total_adionais, 2)
		escreva("\nTotal adicionais: R$", total_adionais)
		total_descontos = desconto_vale_trans + inss + ir
		total_descontos = mat.arredondar(total_descontos, 2)
		escreva("\nTotal descontos: R$", total_descontos)
		escreva("\n_______________________________________________________________________\n")
		salario_liquido = programa_var_salario_bruto + total_adionais - total_descontos
		salario_liquido = mat.arredondar(salario_liquido, 2)
		escreva("\nSalário líquito: R$", salario_liquido, "\n")

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			simulacao_completa()
		}		
	}
	funcao cadastrar_funcionarios()
	{
		cadeia telefone,email,cep,endereco,endereco_sem_cep,posicao,nome,endereco_ate_es
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
			//endereco_sem_cep = txt.substituir(endereco_sem_cep, "," , "\n")
			endereco_ate_es = txt.extrair_subtexto(endereco, 22, 169)
			endereco_ate_es = txt.substituir(endereco_ate_es, ",", "\n")
	
		se(verificar_se_existe_arquivo == verdadeiro)
		{
			inteiro arquivo = a.abrir_arquivo("./banco_dados.txt", a.MODO_ACRESCENTAR)
			a.escrever_linha("FUNCIONÁRIO", arquivo)
			a.escrever_linha("NOME: " + txt.caixa_alta(nome),arquivo)
			a.escrever_linha("IDADE: " + idade, arquivo)
			a.escrever_linha("Email: " + txt.caixa_alta(email), arquivo)
			a.escrever_linha("Telefone: " + txt.caixa_alta(telefone), arquivo)
			a.escrever_linha("Endereço: " + txt.caixa_alta(endereco_ate_es), arquivo)
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
			a.escrever_linha("Endereço: " + txt.caixa_alta(endereco_ate_es), arquivo)
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
			pare
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
 * @POSICAO-CURSOR = 24944; 
 * @DOBRAMENTO-CODIGO = [9, 24, 33, 54, 82, 148, 171, 196, 217, 256, 274, 335, 356, 378, 398, 405, 424, 435, 476, 523, 533, 565, 585, 594, 614, 621, 640, 648, 785];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {verificar_se_existe_arquivo, 727, 9, 27};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */