﻿using iRh.Windows.Cadastros.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();

            cmbEstados.Items.Clear();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";

        }

        private void CarregarDocumentos()
        {
            var documento = new Identificacao();
            var listaDocumentos = documento.ObterDocumentos();

            cmbIdentificacao.Items.Clear();
            var documentosAz = listaDocumentos.OrderBy(x => x.Documento).ToList();
            cmbIdentificacao.DataSource = documentosAz;
            cmbIdentificacao.DisplayMember = "Documento";
            cmbIdentificacao.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            var cepDigitado = txtCep.Text;
            var endereco = new Endereco();
            if(cepDigitado.Length < 9)
            {
                MessageBox.Show("Informe um CEP válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                return;
            }
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);


            try
            {
                txtLogradouro.Text = enderecoCompleto.Logradouro;
                txtBairro.Text = enderecoCompleto.Bairro;
                txtCidade.Text = enderecoCompleto.Localidade;
                txtDdd.Text = enderecoCompleto.Ddd;
                cmbEstados.SelectedValue = enderecoCompleto.Uf;


                if( endereco.Localidade != "")
                {
                    txtCidade.Enabled = false;
                }

                if ( endereco.Ddd != "")
                {
                    txtDdd.Enabled = false;
                }

                if ( endereco.Uf != "")
                {
                    cmbEstados.Enabled = false;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Informe um CEP válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                return;
            }

        }
    }
}
