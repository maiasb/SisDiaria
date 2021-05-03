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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0S0H478\SQLEXPRESS;Initial Catalog=DBDiarias;Integrated Security=True");

        //INICIA O FORM E RECEBE DADOS DO PRIMEIRO
        public Form2(string mat)
        {
            InitializeComponent();
            txtmat.Text = mat;

            SqlCommand com = new SqlCommand("spBuscaServidor2".ToString(), conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MAT", txtmat.Text);

            conn.Open();
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txtnome.Text = dr["NOMESERVIDOR"].ToString();
                txtmat.Text = dr["MAT"].ToString();
                txtcargo.Text = dr["CARGO"].ToString();
                cbolot.Text = dr["LOT"].ToString();
            }

            conn.Close();
        }

        //BOTÃO PERMITE REALIZAR EDIÇÕES NA TABELA SERVIDOR
        private void editar_Click(object sender, EventArgs e)
        {
            Controls.Add(cancel);
            ok.Enabled = true;
            txtnome.Enabled = true;
            txtmat.Enabled = false;
            txtcargo.Enabled = true;
            cbolot.Enabled = true;
            Controls.Remove(editar);
            Controls.Add(cancel);
        }

        //COMANDO SQL PARA CONFIRMAR EDIÇÃO
        private void ok_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtmat.Text == "" || txtcargo.Text == "" || cbolot.Text == "")
            {
                MessageBox.Show("Preencha os campos.", "Caixa de Texto.", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Confirmar Edição?", "EXCLUIR SERVIDOR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString() == "Yes")
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("spEditServidor", conn);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@NOMESERVIDOR", this.txtnome.Text);
                        com.Parameters.AddWithValue("@MAT", this.txtmat.Text);
                        com.Parameters.AddWithValue("@CARGO", this.txtcargo.Text);
                        com.Parameters.AddWithValue("@LOT", this.cbolot.Text);

                        conn.Open();
                        com.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Dados Editados.", "CAIXA DE TEXTO", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro" + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    ok.Enabled = false;
                    txtnome.Enabled = false;
                    txtmat.Enabled = false;
                    txtcargo.Enabled = false;
                    cbolot.Enabled = false;
                    Controls.Remove(cancel);
                    Controls.Add(editar);
                }
            }
        }

        //BOTÃO CANCELA EDIÇÃO (PENDENTE) ----------------------------------------------
        private void cancel_Click(object sender, EventArgs e)
        {
            ok.Enabled = false;
            txtnome.Enabled = false;
            txtmat.Enabled = false;
            txtcargo.Enabled = false;
            cbolot.Enabled = false;
            Controls.Remove(cancel);
            Controls.Add(editar);
        }

        //BOTÃO PARA DELETAR SERVIDOR
        private void delete_Click(object sender, EventArgs e)
        {
            ok.Enabled = false;
            txtnome.Enabled = false;
            txtmat.Enabled = false;
            txtcargo.Enabled = false;
            cbolot.Enabled = false;

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "EXCLUIR SERVIDOR", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString() == "Yes")
            {
                try
                {
                    SqlCommand com = new SqlCommand("spDelServidor", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@NOMESERVIDOR", this.txtnome.Text);
                    com.Parameters.AddWithValue("@MAT", this.txtmat.Text);
                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Servidor Deletado.", "CAIXA DE TEXTO", MessageBoxButtons.OK);
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
                txtmat.Clear();
                txtcargo.Clear();
                cbolot.SelectedIndex = -1;
            }
        }

        //BOTÃO (VOLTAR) QUE FECHA A JANELA DE PESQUISA
        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            txtnome.Clear();
            txtmat.Clear();
            txtcargo.Clear();
            cbolot.SelectedIndex = -1;
        }

        //BOTÃO ABRE TABELA PARA CADASTRAR NOVA DIÁRIA
        private void adcdiaria_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Controls.Clear();

            Controls.Add(lbcodv);
            Controls.Add(txtcodv);
            Controls.Add(lbnome);
            Controls.Add(txtnome);
            Controls.Add(lbmat);
            Controls.Add(txtmat);
            Controls.Add(avancar);
            Controls.Add(voltarv);
            Controls.Add(limparv);
            Controls.Add(cbosaidav);
            Controls.Add(cbochegadav);
            Controls.Add(lbsaida);
            Controls.Add(lbchegada);
            Controls.Add(txtdatas);
            Controls.Add(txtdatac);
            Controls.Add(lbdatas);
            Controls.Add(lbdatac);
            Controls.Add(txthoras);
            Controls.Add(txthorac);
            Controls.Add(lbhoras);
            Controls.Add(lbhorac);

            //SEGUNDA PARTE
            Controls.Add(panel1);
            Controls.Add(txtobj);
            Controls.Add(cboconta);
            Controls.Add(txtvalord);

            panel1.Hide();
            txtobj.Hide();
            cboconta.Hide();
            txtvalord.Hide();
        }

        //BOTÃO LIMPA CAMPOS DA TABELA DE NOVA DIÁRIA
        private void limparv_Click(object sender, EventArgs e)
        {
            txtcodv.Clear();
            cbosaidav.SelectedIndex = -1;
            cbochegadav.SelectedIndex = -1;
            txthoras.Clear();
            txthorac.Clear();
            txtdatas.Clear();
            txtdatac.Clear();
        }

        //BOTÃO VOLTA PARA TABELA ANTERIOR À NOVA DIÁRIA
        private void voltarv_Click(object sender, EventArgs e)
        {
            txtcodv.Clear();
            cbosaidav.SelectedIndex = -1;
            cbochegadav.SelectedIndex = -1;
            txthoras.Clear();
            txthorac.Clear();
            rba.Checked = false;
            rbf.Checked = false;
            rbr.Checked = false;
            txtobj.Clear();

            Form2.ActiveForm.Controls.Clear();
            lbnome.Location = new Point(27, 33);
            txtnome.Location = new Point(192, 30);
            Controls.Add(lbnome);
            Controls.Add(txtnome);
            Controls.Add(lbmat);
            Controls.Add(txtmat);
            Controls.Add(lbcargo);
            Controls.Add(txtcargo);
            Controls.Add(lblot);
            Controls.Add(cbolot);
            Controls.Add(voltar);
            Controls.Add(delete);
            Controls.Add(editar);
            Controls.Add(ok);
            Controls.Add(adcdiaria);
            Controls.Add(adcbanco);
            Controls.Add(adcdoc);
        }

        //AVANÇA PARA SEGUNDA PARTE DA TABELA DIÁRIA E CARREGA CONTAS BANCÁRIAS NO LISTBOX
        private void avancar_Click(object sender, EventArgs e)
        {
            txtcodv.Enabled = false;

            Controls.Remove(avancar);
            Controls.Remove(voltarv);
            Controls.Remove(limparv);
            Controls.Remove(lbsaida);
            Controls.Remove(lbchegada);
            Controls.Remove(lbdatas);
            Controls.Remove(lbdatac);
            Controls.Remove(lbhoras);
            Controls.Remove(lbhorac);
            Controls.Remove(lbcodv);
            Controls.Remove(avancar);
            Controls.Remove(limparv);
            Controls.Remove(voltarv);

            cbosaidav.Hide();
            cbochegadav.Hide();
            txtdatas.Hide();
            txtdatac.Hide();
            txthoras.Hide();
            txthorac.Hide();
            txtcodv.Hide();

            txtobj.Show();
            panel1.Show();
            cboconta.Show();
            txtvalord.Show();

            Controls.Add(lbconta);
            Controls.Add(lbvalord);
            Controls.Add(lbtipo);
            Controls.Add(lbobj);
            Controls.Add(txtobj);
            Controls.Add(cviajem);
            Controls.Add(limparv2);
            Controls.Add(voltarv2);

            conn.Open();
            SqlCommand com = new SqlCommand("spBuscaConta", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MAT", txtmat.Text);
            SqlDataReader rd = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rd);
            DataRow row = table.NewRow();
            //row["CONTA"] = "";
            //table.Rows.InsertAt(row, 1);

            cboconta.DataSource = table;
            cboconta.ValueMember = "CONTA";
            cboconta.DisplayMember = "BANCO";

            rd.Close();
            rd.Dispose();
            conn.Close();
        }

        //PERMITE APENAS NÚMEROS NO TXTVALORD
        private void num(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //RETORNA À PRIMEIRA PARTE DA TABELA DIÁRIA
        private void voltarv2_Click(object sender, EventArgs e)
        {
            txtcodv.Enabled = true;

            Controls.Add(avancar);
            Controls.Add(voltarv);
            Controls.Add(limparv);
            Controls.Add(lbsaida);
            Controls.Add(lbchegada);
            Controls.Add(lbdatas);
            Controls.Add(lbdatac);
            Controls.Add(lbhoras);
            Controls.Add(lbhorac);
            Controls.Add(lbcodv);
            Controls.Add(avancar);
            Controls.Add(limparv);
            Controls.Add(voltarv);

            cbosaidav.Show();
            cbochegadav.Show();
            txtdatas.Show();
            txtdatac.Show();
            txthoras.Show();
            txthorac.Show();
            txtcodv.Show();

            txtobj.Hide();
            panel1.Hide();
            cboconta.Hide();
            txtvalord.Hide();

            Controls.Remove(lbconta);
            Controls.Remove(lbvalord);
            Controls.Remove(lbtipo);
            Controls.Remove(lbobj);
            Controls.Remove(cviajem);
            Controls.Remove(limparv2);
            Controls.Remove(voltarv2);
        }

        //LIMPA SEGUNDA PARTE DA TABELA DIÁRIA
        private void limparv2_Click(object sender, EventArgs e)
        {
            rba.Checked = false;
            rbf.Checked = false;
            rbr.Checked = false;
            txtoutros.Clear();
            txtobj.Clear();
            txtvalord.Clear();
            cboconta.SelectedIndex = -1;
        }

        //BOTÃO CADASTRA NOVA DIÁRIA (PENDENTE) AINDA NÃO VINCULA À CONTA DO USUÁRIO -------------------------------------------------
        private void cviajem_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtmat.Text == "" || txtcodv.Text == "" || cbosaidav.Text == "" || txthoras.Text == "" ||
            txtdatas.Text == "" || cbochegadav.Text == "" || txthorac.Text == "" || txtdatac.Text == "" || txtobj.Text == "")
            {
                MessageBox.Show("Preencha os campos.", "Caixa de Texto", MessageBoxButtons.OK);
            }
            else
            {

                DialogResult confirm = MessageBox.Show("Deseja finalizar cadastro?", "EXCLUIR SERVIDOR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString() == "Yes")
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("spCadDiaria", conn);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@MAT", this.txtmat.Text);
                        com.Parameters.AddWithValue("@ID_DIARIA", this.txtcodv.Text);
                        com.Parameters.AddWithValue("@SAIDA", this.cbosaidav.Text);
                        com.Parameters.AddWithValue("@HORAS", this.txthoras.Text);
                        com.Parameters.AddWithValue("@DATAS", this.txtdatas.Text);
                        com.Parameters.AddWithValue("@DESTINO", this.cbochegadav.Text);
                        com.Parameters.AddWithValue("@HORAD", this.txthorac.Text);
                        com.Parameters.AddWithValue("@DATAD", this.txtdatac.Text);
                        com.Parameters.AddWithValue("@VALORD", this.txtvalord.Text);

                        if (rba.Checked)
                        {
                            com.Parameters.AddWithValue("@TIPO", this.rba.Text);
                        }
                        else if (rbf.Checked)
                        {
                            com.Parameters.AddWithValue("@TIPO", this.rbf.Text);
                        }
                        else if (rbr.Checked)
                        {
                            com.Parameters.AddWithValue("@TIPO", this.rbr.Text);
                        }
                        else
                        {
                            com.Parameters.AddWithValue("@TIPO", this.txtoutros.Text);
                        }
                        com.Parameters.AddWithValue("@OBJ", this.txtobj.Text);

                        conn.Open();
                        com.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cadastro Realizado!", "CAIXA DE TEXTO", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro." + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    txtcodv.Clear();
                    cbosaidav.SelectedIndex = -1;
                    cbochegadav.SelectedIndex = -1;
                    txthoras.Clear();
                    txthorac.Clear();
                    txtdatas.Clear();
                    txtdatac.Clear();
                    txtvalord.Clear();
                    rba.Checked = false;
                    rbf.Checked = false;
                    rbr.Checked = false;
                    txtobj.Clear();
                }
            }
        }

        //BOTÃO ABRE TABELA PARA CADASTRAR CONTA BANCÁRIA
        private void adcbanco_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Controls.Clear();

            Controls.Add(lbnome);
            Controls.Add(txtnome);
            txtnome.Enabled = false;
            Controls.Add(lbmat);
            Controls.Add(txtmat);
            txtmat.Enabled = false;
            Controls.Add(lbbanco);
            Controls.Add(txtbanco);
            Controls.Add(lbconta2);
            Controls.Add(txtconta);
            Controls.Add(voltarcb);
            Controls.Add(limparcb);
            Controls.Add(ccbancaria);
        }

        //COMANDO PARA CADASTRAR CONTA BANCÁRIA
        private void ccbancaria_Click(object sender, EventArgs e)
        {
            if (txtbanco.Text == "" || txtconta.Text == "")
            {
                MessageBox.Show("Preencha os campos.", "Caixa de Texto", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Confirmar Cadastro?", "EXCLUIR SERVIDOR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString() == "Yes")
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("spCadBancaria", conn);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@NOMESERVIDOR", this.txtnome.Text);
                        com.Parameters.AddWithValue("@MAT", this.txtmat.Text);
                        com.Parameters.AddWithValue("@BANCO", this.txtbanco.Text);
                        com.Parameters.AddWithValue("@CONTA", this.txtconta.Text);

                        conn.Open();
                        com.ExecuteReader();
                        conn.Close();

                        MessageBox.Show("Conta Bancária Adicionada.", "Caixa de Texto", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro" + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    txtbanco.Clear();
                    txtconta.Clear();
                }
            }
        }

        //BOTÃO LIMPA TABELA DE CONTA BANCÁRIA
        private void limparcb_Click(object sender, EventArgs e)
        {
            txtbanco.Clear();
            txtconta.Clear();
        }

        //BOTÃO VOLTA PARA TABELA DO SERVIDOR
        private void voltarcb_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Controls.Clear();

            Controls.Add(lbnome);
            Controls.Add(txtnome);
            Controls.Add(lbmat);
            Controls.Add(txtmat);
            Controls.Add(lblot);
            Controls.Add(cbolot);
            Controls.Add(lbcargo);
            Controls.Add(txtcargo);
            Controls.Add(lblot);
            Controls.Add(cbolot);
            Controls.Add(adcbanco);
            Controls.Add(adcdiaria);
            Controls.Add(voltar);
            Controls.Add(delete);
            Controls.Add(editar);
            Controls.Add(ok);
            Controls.Add(adcbanco);
            Controls.Add(adcdoc);
        }



        //JOGO DE MARCAÇÕES (RBS E TXT)
        private void rba_CheckedChanged(object sender, EventArgs e)
        {
            txtoutros.Clear();
        }

        private void rbr_CheckedChanged(object sender, EventArgs e)
        {
            txtoutros.Clear();
        }

        private void rbf_CheckedChanged(object sender, EventArgs e)
        {
            txtoutros.Clear();
        }

        private void txtoutros_TextChanged(object sender, EventArgs e)
        {
            rba.Checked = false;
            rbf.Checked = false;
            rbr.Checked = false;
        }
    }
}
