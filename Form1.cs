using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txt_cep.Text);
                ds.ReadXml(xml);
                txt_logra.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txt_bairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txt_cidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txt_uf.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
