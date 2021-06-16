using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DIÁRIAS_DEFINITIVO
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PC_MAIA"].ConnectionString);

        //INICIA O FORM
        public Form1()
        {
            InitializeComponent();
        }

        //ABRIR TABELA DE CADASTRO
        private void mcadserv_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Controls.Clear();
            Controls.Add(lbnome);
            Controls.Add(txtnome);
            Controls.Add(lbmat);
            Controls.Add(lbcargo);
            Controls.Add(lblot);
            Controls.Add(txtmat);
            Controls.Add(txtcargo);
            Controls.Add(cbolot);
            Controls.Add(cadastrarcs);
            Controls.Add(Limparcs);
            Controls.Add(Voltarcs);
        }

        //CADASTRAR DADOS DA TABELA DE CADASTRO DE SERVIDOR
        private void cadastrarcs_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtmat.Text == "" || txtcargo.Text == "" || cbolot.Text == "")
            {
                MessageBox.Show("Preencha os Campos.", "Caixa de Texto", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Deseja confirmar cadastro?", "EXCLUIR SERVIDOR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString() == "Yes")
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("spCadServidor", conn);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@NOMESERVIDOR", this.txtnome.Text);
                        com.Parameters.AddWithValue("@MAT", this.txtmat.Text);
                        com.Parameters.AddWithValue("@CARGO", this.txtcargo.Text);
                        com.Parameters.AddWithValue("@LOT", this.cbolot.Text);

                        conn.Open();
                        com.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cadastro realizado com sucesso.", "CAIXA DE TEXTO", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro" + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    txtnome.Clear();
                    txtcargo.Clear();
                    txtcpf.Clear();
                    txtmat.Clear();
                    cbolot.SelectedIndex = -1;
                }
            }
        }

        //LIMPAR DADOS DA TABELA DE CADASTRO
        private void Limparcs_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtcargo.Clear();
            txtcpf.Clear();
            txtmat.Clear();
            cbolot.SelectedIndex = -1;
        }

        //VOLTAR PARA O MENU INICIAL
        private void Voltarcs_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Controls.Clear();
            Controls.Add(btcadservidor);
            Controls.Add(btbuscaservidor);
            Controls.Add(btbuscadiaria);
            Controls.Add(btbuscadiaria);

            txtnome.Clear();
            txtmat.Clear();
            txtcodv.Clear();
            listBox1.Items.Clear();
        }

        //ABRE TABELA PARA BUSCAR DE SERVIDOR
        private void mbuscas_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Controls.Clear();
            Controls.Add(listBox1);
            Controls.Add(lbnome);
            Controls.Add(txtnome);
            Controls.Add(lbmat);
            Controls.Add(txtmat);
            Controls.Add(buscars);
            Controls.Add(selservidor);
            Controls.Add(limparbs);
            Controls.Add(Voltarcs);
        }

        //PERMITE APENAS NÚMEROS NO TXTMAT
        private void num(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //PERMITE APENAS LETRAS NO TXTNOME (PENDENTE) ---------------------------------------
        private void cchar(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            //{
            //    e.Handled = true;
            //}
        }

        //PREENCHE LISTBOX COM OS RESULTADOS DA BUSCA DO SERVIDOR
        public void buscars_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" && txtmat.Text == "")
            {
                MessageBox.Show("Preencha os campos.", "Caixa de Texto.", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    listBox1.Items.Clear();
                    SqlCommand com = new SqlCommand("spBuscaServidor".ToString(), conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@NOMESERVIDOR", txtnome.Text);
                    com.Parameters.AddWithValue("@MAT", txtmat.Text);

                    conn.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        listBox1.Items.Add("Nome: " + dr["NOMESERVIDOR"].ToString() + "     Matrícula: " + dr["MAT"].ToString());
                        listBox1.Items.Add("");
                        listBox1.Items.Add("");
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //MANDA MATRÍCULA ESCOLHIDA PARA O FORM2
        private void selservidor_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecione um Servidor", "Caixa de Texto.", MessageBoxButtons.OK);
            }
            else
            {
                string txt = listBox1.SelectedItem.ToString();
                int found = 0;
                found = txt.IndexOf("a: ");
                txt = txt.Substring(found + 3);

                //SE LIGA AQUI -----------------------------------------------------------------------------
                txtnome.Clear();
                txtmat.Clear();
                listBox1.Items.Clear();

                Form2 f2 = new Form2(txt);
                f2.Show();
            }
        }

        //LIMPAR DADOS DA BUSCA DE SERVIDOR
        private void limparbs_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtmat.Clear();
            listBox1.Items.Clear();
        }

        //ABRE TABELA PARA PESQUISAR DIÁRIAS
        private void btbuscadiaria_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Controls.Clear();
            Controls.Add(buscard);
            Controls.Add(lbcodv);
            Controls.Add(txtcodv);
            Controls.Add(listBox1);
            Controls.Add(Voltarcs);
        }

        //BUSCA  A DIÁRIA
        private void buscard_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" && txtmat.Text == "" && txtcodv.Text == "")
            {
                MessageBox.Show("Forneça alguma das informações.", "Caixa de Texto.", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    listBox1.Items.Clear();
                    SqlCommand com = new SqlCommand("spBuscaDiaria", conn);
                    SqlCommand com2 = new SqlCommand("spBuscaDiaria2", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com2.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ID_DIARIA", this.txtcodv.Text);
                    com2.Parameters.AddWithValue("@ID_DIARIA", this.txtcodv.Text);

                    conn.Open();
                    com2.ExecuteNonQuery();
                    SqlDataReader dr2 = com2.ExecuteReader();
                    if (dr2.Read())
                    {
                        listBox1.Items.Add("Nome: " + dr2["NOMESERVIDOR"]);
                        listBox1.Items.Add("Matrícula: " + dr2["MAT"]);
                    }
                    conn.Close();

                    conn.Open();
                    com.ExecuteNonQuery();
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        listBox1.Items.Add("Número Diária: " + dr["ID_DIARIA"]);
                        listBox1.Items.Add("Saída: " + dr["SAIDA"]);
                        listBox1.Items.Add("Data Saída: " + dr["DATAS"]);
                        listBox1.Items.Add("Hora Saída: " + dr["HORAS"]);
                        listBox1.Items.Add("Destino: " + dr["DESTINO"]);
                        listBox1.Items.Add("Data Destino: " + dr["DATAD"]);
                        listBox1.Items.Add("Hora Destino: " + dr["HORAD"]);
                        listBox1.Items.Add("Passagem: " + dr["TIPO"]);
                        listBox1.Items.Add("Objetivo: " + dr["OBJ"]);
                        listBox1.Items.Add("");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
