programa
{
	inclua biblioteca Texto--> txt
	inclua biblioteca Matematica --> mat
	inclua biblioteca Arquivos --> a
	inclua biblioteca ServicosWeb --> WS

		cadeia nome[10] = {"","","","","","","","","",""}
		cadeia telefone,email,cep,endereco,endereco_sem_cep,posicao
		inteiro idade[10],caracteres,funcionarios
		
	
	real salario_bruto, horas_extra, noturno, valor_hora, hora_trabalhada
	cadeia periculosidade, vale_transporte
	funcao inicio()
	{
		escreva("           Ótimo Dia!\n")
		escreva("-> Quantas horas trabalhadas? ")
		leia(hora_trabalhada)
		escreva("-> Qual o valor da hora trabalhada? ")
		leia(valor_hora)
		salario_bruto = valor_hora * hora_trabalhada
		escreva("-> Quantas horas extras? ")
		leia(horas_extra)
		escreva("-> Quantas horas noturnas? ")
		leia(noturno)
		insalubridade()
		
	}
	funcao insalubridade()
	{
		escreva("-> Recebe adicional de periculosidade (S) ou (N)? ")
		leia(periculosidade)
		periculosidade = txt.caixa_alta(periculosidade)
		se(periculosidade != "S")
		{
			se(periculosidade != "N")
			{
				limpa()
				escreva("Coloque alguma das duas opções! (S) ou (N)\n")
				insalubridade()
			}
			senao
			{
				vale_trans()
			}
		}
		senao
		{
			vale_trans()
		}
	}
	funcao vale_trans()
	{
		escreva("-> Recebe vale transporte (S) ou (N)? ")
		leia(vale_transporte)
		vale_transporte = txt.caixa_alta(vale_transporte)
		se(vale_transporte != "S")
		{
			se(vale_transporte != "N")
			{
				limpa()
				escreva("Coloque alguma das duas opções! (S) ou (N)\n")
				vale_trans()
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
				retorno_inss()
			pare
			caso 2:
				limpa()
				retorno_ferias()
			pare
			caso 3: 
				limpa()
				retorno_IR()
			pare
			caso 4:
				limpa()
				retorno_FGTS()
			pare
			caso 5:
				limpa()
				retorno_multa_FGTS()
			pare
			caso 6:
				limpa()
				seguro_desemprego()
			pare
			caso 7:
				limpa()
				retorno_vale_transporte()
			pare
			caso 8: 
				limpa()
				calculo_pis()
			pare
			caso 9:
				limpa()
				retorno_ad_noturno()
			pare	
			caso 10:
				limpa()
				retorno_ad_periculosidade()
			pare
			caso 11:
				limpa()
				retorno_ad_horas_extras()
			pare
			caso 12:
				limpa()
				simulacao_completa()
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
		caracter fechar_programa
		logico validar_escolha
		faca
		{	
			escreva("\n______________________________________________________________________\n")
			escreva("Deseja voltar ao menu? (s)Sim (n)Não\n")
			leia (fechar_programa)
			se(fechar_programa == 's' ou fechar_programa == 'n')
			{
				validar_escolha = falso
			}
			senao
			{
				validar_escolha =  verdadeiro	
			}	
		}enquanto(validar_escolha)
				
		se(fechar_programa == 's')
		{
			retorne verdadeiro
		}
		senao
		{
			retorne falso
		}
	}
	funcao retorno_inss()
	{
		real salario_bruto_inss, inss
		escreva("_______________________________________________________________________\n")
	 	escreva("___________________Simulador de descontos do INSS______________________\n")
	 	escreva("\n\n")
	 	salario_bruto_inss = salario_bruto
	 	inss = desconto_inss(salario_bruto_inss)
	 	inss = mat.arredondar(inss, 2)
	 	escreva("Valor do desconto do INSS: R$", inss)

	 	logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_inss()
		}
	}
	funcao real desconto_inss(real salario_bruto_inss)
	{
		const real faixa_salarial = 1302.00
		const real faixa_salarial2 =2571.29
		const real faixa_salarial3 =3856.94
		real desconto_1, desconto_2, desconto_3, desconto_4

		se(salario_bruto_inss <= faixa_salarial)
		{
			desconto_1 = (salario_bruto_inss * 0.075)
			desconto_1 = mat.arredondar(desconto_1, 2)
			retorne desconto_1
		}
		senao se(salario_bruto <= faixa_salarial2)
		{
			desconto_1 = (salario_bruto_inss * 0.075)
			desconto_2 = 0.09 * (salario_bruto_inss - faixa_salarial) + desconto_1
			desconto_2 = mat.arredondar(desconto_2, 2)
			retorne desconto_2
		}
		senao se(salario_bruto <= faixa_salarial3)
		{
			desconto_1 = (salario_bruto_inss * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (salario_bruto_inss - faixa_salarial2) + desconto_1 + desconto_2
			desconto_3 = mat.arredondar(desconto_3, 2)
			retorne desconto_3
		}	
		senao se(salario_bruto >=  faixa_salarial3)
		{
			desconto_1 = (salario_bruto_inss * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (faixa_salarial3 - faixa_salarial2)
			desconto_4 = 0.14 * (salario_bruto_inss - faixa_salarial3) +  desconto_1 + desconto_2 + desconto_3
			desconto_4 = mat.arredondar(desconto_4, 2)
			retorne desconto_4
		}
		retorne 0.0
	}
	funcao retorno_ferias()
	{
		real adicional_ferias, salario_bruto_ferias
		salario_bruto_ferias = salario_bruto
		adicional_ferias = ferias(salario_bruto_ferias)
		adicional_ferias = mat.arredondar(adicional_ferias, 2)
		escreva(adicional_ferias)
		
		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_ferias()
		}
	}
	funcao real ferias(real salario_bruto_ferias)
	{
		const real faixa_salarial = 1302.00
		const real faixa_salarial2 =2571.29
		const real faixa_salarial3 =3856.94
		real desconto_1, desconto_2, desconto_3, desconto_4
		inteiro dias_de_ferias
		real IR, valor_ferias, IR_ferias, IR_INSS, desconto_INSS = 0.0
		
		se(salario_bruto < 2826.66)
		{
			IR = salario_bruto * 0.075/3
		}
		senao se(salario_bruto < 3751.06)
		{
			IR = salario_bruto * 0.15/3
		}
		senao se(salario_bruto < 4664.69)
		{
			IR = salario_bruto * 0.225/3
		}
		senao
		{
			IR =salario_bruto * 0.275/3
		}
		
		se(salario_bruto <= faixa_salarial)
		{
			desconto_1 = (salario_bruto * 0.075)/3
			desconto_INSS = desconto_1
		}
		senao se(salario_bruto <= faixa_salarial2)
		{
			desconto_1 = (salario_bruto * 0.075)
			desconto_2 = 0.09 * ((salario_bruto - faixa_salarial) + desconto_1)/3
			desconto_INSS = desconto_2
		}
		senao se(salario_bruto <= faixa_salarial3)
		{
			desconto_1 = (salario_bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * ((salario_bruto - faixa_salarial2) + desconto_1 + desconto_2)/3
			desconto_INSS = desconto_3
		}	
		senao se(salario_bruto >=  faixa_salarial3)
		{
			desconto_1 = (salario_bruto * 0.075)
			desconto_2 = 0.09 * (faixa_salarial2 - faixa_salarial)
			desconto_3 = 0.12 * (faixa_salarial3 - faixa_salarial2)
			desconto_4 = 0.14 * ((salario_bruto - faixa_salarial3) +  desconto_1 + desconto_2 + desconto_3)/3
			desconto_INSS = desconto_4
		}

		IR_INSS = IR + desconto_INSS
		valor_ferias = salario_bruto/3 - IR_INSS
		escreva("______________________________________________________________________\n")
		escreva("____________________Simulador de Adicional de Férias__________________\n")
		escreva("\nO colaborador receberá a mais R$ ")
		 valor_ferias= mat.arredondar(valor_ferias, 2)
		retorne valor_ferias
	}
	funcao retorno_IR()
	{
		real salario_IR, desconto_IR
		salario_IR = salario_bruto
		desconto_IR = imposto_de_renda(salario_IR)
		desconto_IR = mat.arredondar(desconto_IR, 2)
		escreva("_____________________________________________________________________\n")
		escreva("________________Simulador de Desconto de Imposto de Renda____________\n")
		escreva("\nValor do desconto do Imposto de Renda: R$", desconto_IR)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_IR()
		}
		
	}
	funcao real imposto_de_renda(real salario_IR)
	{
		real IR
		se(salario_bruto < 2826.66)
		{
			IR = salario_bruto * 0.075
		}
		senao se(salario_bruto < 3751.06)
		{
			IR = salario_bruto * 0.15
		}
		senao se(salario_bruto < 4664.69)
		{
			IR = salario_bruto * 0.225
		}
		senao
		{
			IR =salario_bruto * 0.275
		}
		IR = mat.arredondar(IR, 2)
		retorne IR
	}
	funcao retorno_FGTS()
	{
		real salario_FGTS, desconto_FGTS
		salario_FGTS = salario_bruto
		desconto_FGTS = FGTS(salario_FGTS)
		desconto_FGTS = mat.arredondar(desconto_FGTS, 2)
		escreva("______________________________________________________________________\n")
		escreva("____________________Simulador de Desconto do FGTS_____________________\n")
		escreva("\nO desconto é de R$", desconto_FGTS)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_FGTS()
		}
	}
	funcao real FGTS(real salario_FGTS)
	{
		real fgts
		fgts = salario_bruto * 0.08
		fgts = mat.arredondar(fgts, 2)
		retorne fgts
	}
	funcao retorno_multa_FGTS()
	{
		real salario_multa, valor_multa
		salario_multa = salario_bruto
		valor_multa = multa_FGTS(salario_multa)
		valor_multa = mat.arredondar(valor_multa, 2)
		
		escreva("\nO valor da multa é de R$", valor_multa)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_multa_FGTS()
		}
	}
	funcao real multa_FGTS(real salario_multa)
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
	funcao seguro_desemprego()
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
			seguro_desemprego()
		}
	}
	funcao retorno_vale_transporte()
	{
		real desconto_VT, salario_VT
		cadeia simnao
		const real  passagem = 4.20
		
		salario_VT = salario_bruto
		desconto_VT = desconto_vale_transporte(salario_VT)
		desconto_VT = mat.arredondar(desconto_VT, 2)
		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Vale-Transporte___________________\n")
		escreva("\nO valor de desconto de R$", desconto_VT, "\n")
		escreva("Gostaria que o sistema calcule e mostre se vale a pena ou não ele usar o benefício (S) ou (N)? ")
		leia(simnao)
		simnao = txt.caixa_alta(simnao)
		se(simnao == "S")
		{
			se(desconto_VT > 4 * passagem * 20)
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
			retorno_vale_transporte()
		}
				
		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_vale_transporte()
		}	
	}
	funcao real desconto_vale_transporte(real salario_VT)
	{
		const real porcentagem_desconto= 0.06
		real desconto_vale_trans
		
		desconto_vale_trans = salario_bruto * porcentagem_desconto
		desconto_vale_trans = mat.arredondar(desconto_vale_trans, 2)
		retorne desconto_vale_trans
		
	}
	funcao calculo_pis()
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
			calculo_pis()
		}	
	}
	funcao retorno_ad_noturno()
	{
		real salario_an, ad_noturno
		salario_an = salario_bruto
		ad_noturno = adicional_noturno(salario_an)
		ad_noturno = mat.arredondar(ad_noturno, 2)
		escreva("______________________________________________________________________\n")
		escreva("_____________________Simulador de Adicional Noturno___________________\n")
		escreva("\nO valor de adicional noturno é de R$",ad_noturno)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_ad_noturno()
		}	
	}
	funcao real adicional_noturno(real salario_an)
	{
		real salario_descontado, salario_hora, valor_adicional_noturno

		valor_adicional_noturno = ( valor_hora * 0.2) * noturno
		salario_descontado = (salario_bruto) + valor_adicional_noturno
		valor_adicional_noturno = mat.arredondar(valor_adicional_noturno, 2)
		retorne valor_adicional_noturno
	}
	funcao retorno_ad_periculosidade()
	{
		real valor_adicional_periculosidade, salario_periculosidade
		salario_periculosidade = salario_bruto
		valor_adicional_periculosidade = adicional_periculosidade(salario_periculosidade)
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
			retorno_ad_periculosidade()
		}	
	}
	funcao real adicional_periculosidade(real salario_periculosidade)
	{
		real valor_adicional_periculosidade
		valor_adicional_periculosidade = salario_bruto * 0.3
		valor_adicional_periculosidade = mat.arredondar(valor_adicional_periculosidade, 2)
		retorne valor_adicional_periculosidade
	}
	funcao retorno_ad_horas_extras()
	{
		real salario_hora_extra, ad_hora_extra
		salario_hora_extra = salario_bruto
		ad_hora_extra = adicional_horas_extras(salario_hora_extra)
		escreva("______________________________________________________________________\n")
		escreva("___________________Simulador de Adicional Horas Extras________________\n")
		escreva("\nO valor adicional de horas extras é de R$",ad_hora_extra)

		logico resultado = volta_menu()
		se(resultado == verdadeiro)
		{
			inicio_menu()
		}
		senao se(resultado == falso)
		{
			retorno_ad_horas_extras()
		}	
	}
	funcao real adicional_horas_extras(real salario_hora_extra)
	{
		real valor_adicional_horas_extras

		valor_adicional_horas_extras = (valor_hora * 1.5) * horas_extra
		valor_adicional_horas_extras = mat.arredondar(valor_adicional_horas_extras, 2)
		retorne valor_adicional_horas_extras
	}
	funcao simulacao_completa()
	{
		limpa()
		real total_adionais, total_descontos, inss, salario_bruto_inss, salario_FGTS, fgts, desconto_vale_trans, salario_VT, IR, salario_IR, ad_noturno, salario_an, valor_adicional_periculosidade, salario_periculosidade, salario_hora_extra, ad_hora_extra, salario_liquido
		escreva("_________________________Simulação Completa____________________________\n")
		escreva("_______________________________________________________________________\n")
		escreva("Salário Bruto: R$", salario_bruto)
		escreva("\nHoras extras: ", horas_extra, " horas\n")
		escreva("Noturno: ", noturno, " horas \n")
		escreva("Periculosidade: ", periculosidade)
		escreva("\nVale transporte: ", vale_transporte, "\n")
		
		escreva("\n_________________________Detalhamento________________________________\n")
		escreva("\nSalário base: R$", salario_bruto)
		salario_hora_extra = salario_bruto
		ad_hora_extra = adicional_horas_extras(salario_hora_extra)
		escreva("\nHoras extras: + R$", ad_hora_extra)
		salario_an = salario_bruto
		ad_noturno = adicional_noturno(salario_an)
		escreva("\nNoturno: + R$", ad_noturno)
		salario_periculosidade = salario_bruto
		valor_adicional_periculosidade = adicional_periculosidade(salario_periculosidade)
		se(periculosidade == "S")
		{
			escreva("\nPericulosidade: + R$", valor_adicional_periculosidade)
		}
		senao
		{
			valor_adicional_periculosidade = 0.00
			escreva("\nPericulosidade: + R$", valor_adicional_periculosidade)
		}		
		salario_FGTS = salario_bruto
		fgts = FGTS(salario_FGTS)
		escreva("\nFGTS: + R$", fgts)
		salario_VT = salario_bruto
		desconto_vale_trans = desconto_vale_transporte(salario_VT)
		se(vale_transporte == "S")
		{
			escreva("\nVale transporte: - R$", desconto_vale_trans)
		}
		senao
		{
			desconto_vale_trans = 0.00
			escreva("\nVale transporte: - R$", desconto_vale_trans)
		}
		salario_bruto_inss = salario_bruto
		inss = desconto_inss(salario_bruto_inss)
		escreva("\nINSS: - R$", inss)
		salario_IR = salario_bruto
		IR = imposto_de_renda(salario_IR)
		escreva("\nImposto de Renda: - R$", IR)

		escreva("\n__________________________Resultado____________________________________\n")
		total_adionais = ad_hora_extra + valor_adicional_periculosidade + fgts + ad_noturno
		total_adionais = mat.arredondar(total_adionais, 2)
		escreva("\nTotal adicionais: R$", total_adionais)
		total_descontos = desconto_vale_trans + inss + IR
		total_descontos = mat.arredondar(total_descontos, 2)
		escreva("\nTotal descontos: R$", total_descontos)
		escreva("\n_______________________________________________________________________\n")
		salario_liquido = salario_bruto + total_adionais - total_descontos
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
	funcao repetidor_cadastro()
	{
		inteiro arquivo = a.abrir_arquivo("./banco_dados.txt", a.MODO_ESCRITA)
		para(inteiro i = 1; i <= 50;i++)
		{
		escreva("------------ CADASTRO DE FUNCIONÁRIO ----------\n")
		escreva("Digite seu nome completo: ")
		leia(nome[i])
		escreva("Digite sua idade: ")
		leia(idade[i])
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
		
		
		a.escrever_linha("FUNCIONÁRIO", arquivo)
		a.escrever_linha("NOME: " + txt.caixa_alta(nome[i]),arquivo)
		a.escrever_linha("IDADE: " + idade[i], arquivo)
		a.escrever_linha("Email: " + txt.caixa_alta(email), arquivo)
		a.escrever_linha("Telefone: " + txt.caixa_alta(telefone), arquivo)
		a.escrever_linha("Endereço: " + txt.caixa_alta(endereco_sem_cep), arquivo)
		a.escrever_linha("\n", arquivo)

		logico resultado = volta_cadastro()
		se(resultado)
		{
			limpa()
		}
		senao
		{
			a.fechar_arquivo(arquivo)
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
 * @POSICAO-CURSOR = 21166; 
 * @DOBRAMENTO-CODIGO = [29, 52, 77, 86, 106, 172, 221, 278, 339, 360, 382, 402, 409, 428, 439, 480, 527, 537, 569, 589, 598, 618, 625, 644, 768];
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */