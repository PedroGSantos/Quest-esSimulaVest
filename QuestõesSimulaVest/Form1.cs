using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace QuestõesSimulaVest
{
    public partial class dsd : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "J3Qda4HpaFzYRsGO2ZirHgKzr9UKUzce0SsXniz5",
            BasePath = "https://fir-vestibular.firebaseio.com/"
        };
        IFirebaseClient client;
        public dsd()
        {
            InitializeComponent();
        }

        class Class1
        {
            public void Exibir()
            {

            }
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            if (txtquest.Text != "" && txta.Text != "" && txtb.Text != "" && txtc.Text != "" && txtd.Text != "" && cbovest.Text != "" && cbomat.Text != "" && cbocorreto.Text != "" && cboassunto.Text != "")
            {
               
                if (cbovest.Text == "Unicamp")
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Contador/Contador_Unicamp/Node");
                    Contador_classe get = resp.ResultAs<Contador_classe>();

                    MessageBox.Show(get.Cont);
                    var data = new Data
                    {
                        Vestibular = cbovest.Text,
                        ID = (Convert.ToInt32(get.Cont) + 1).ToString(),
                        Matéria = cbomat.Text,
                        Enunciado = txtquest.Text,
                        Alternativa_A = txta.Text,
                        Alternativa_B = txtb.Text,
                        Alternativa_C = txtc.Text,
                        Alternativa_D = txtd.Text,
                        Alternativa_E = txte.Text,
                        Correta = cbocorreto.Text,
                        Assunto = cboassunto.Text,
                        Img = txtimg.Text,

                    };
                    SetResponse response = await client.SetTaskAsync("Questões/Unicamp/"+ data.ID+"/", data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Questão da " + result.Vestibular + " inserida");
                    var obj = new Contador_classe
                    {
                        Cont = data.ID
                    };
                    SetResponse resp1 = await client.SetTaskAsync("Contador/Contador_Unicamp/Node", obj);
                }
                if (cbovest.Text == "UNESP")
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Contador/Contador_UNESP/Node");
                    Contador_classe get = resp.ResultAs<Contador_classe>();

                    MessageBox.Show(get.Cont);
                    var data = new Data
                    {
                        Vestibular = cbovest.Text,
                        ID = (Convert.ToInt32(get.Cont) + 1).ToString(),
                        Matéria = cbomat.Text,
                        Enunciado = txtquest.Text,
                        Alternativa_A = txta.Text,
                        Alternativa_B = txtb.Text,
                        Alternativa_C = txtc.Text,
                        Alternativa_D = txtd.Text,
                        Alternativa_E = txte.Text,
                        Correta = cbocorreto.Text,
                        Assunto = cboassunto.Text,
                        Img = txtimg.Text,

                    };
                    SetResponse response = await client.SetTaskAsync("Questões/UNESP/" + data.ID + "/", data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Questão da " + result.Vestibular + " inserida");
                    var obj = new Contador_classe
                    {
                        Cont = data.ID
                    };
                    SetResponse resp1 = await client.SetTaskAsync("Contador/Contador_UNESP/Node", obj);
                }
                if (cbovest.Text == "ENEM")
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Contador/Contador_ENEM/Node");
                    Contador_classe get = resp.ResultAs<Contador_classe>();

                    MessageBox.Show(get.Cont);
                    var data = new Data
                    {
                        Vestibular = cbovest.Text,
                        ID = (Convert.ToInt32(get.Cont) + 1).ToString(),
                        Matéria = cbomat.Text,
                        Enunciado = txtquest.Text,
                        Alternativa_A = txta.Text,
                        Alternativa_B = txtb.Text,
                        Alternativa_C = txtc.Text,
                        Alternativa_D = txtd.Text,
                        Alternativa_E = txte.Text,
                        Correta = cbocorreto.Text,
                        Assunto = cboassunto.Text,
                        Img = txtimg.Text,
                    };
                    SetResponse response = await client.SetTaskAsync("Questões/ENEM/" + data.ID + "/", data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Questão da " + result.Vestibular + " inserida");
                    var obj = new Contador_classe
                    {
                        Cont = data.ID
                    };
                    SetResponse resp1 = await client.SetTaskAsync("Contador/Contador_ENEM/Node", obj);
                }
                if (cbovest.Text == "Fuvest")
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Contador/Contador_Fuvest/Node");
                    Contador_classe get = resp.ResultAs<Contador_classe>();

                    MessageBox.Show(get.Cont);
                    var data = new Data
                    {
                        Vestibular = cbovest.Text,
                        ID = (Convert.ToInt32(get.Cont) + 1).ToString(),
                        Matéria = cbomat.Text,
                        Enunciado = txtquest.Text,
                        Alternativa_A = txta.Text,
                        Alternativa_B = txtb.Text,
                        Alternativa_C = txtc.Text,
                        Alternativa_D = txtd.Text,
                        Alternativa_E = txte.Text,
                        Correta = cbocorreto.Text,
                        Assunto = cboassunto.Text,
                        Img = txtimg.Text,
                    };
                    SetResponse response = await client.SetTaskAsync("Questões/FUVEST/" + data.ID + "/", data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Questão da " + result.Vestibular + " inserida");
                    var obj = new Contador_classe
                    {
                        Cont = data.ID
                    };
                    SetResponse resp1 = await client.SetTaskAsync("Contador/Contador_Fuves/Node", obj);
                }
                FirebaseResponse respe = await client.GetTaskAsync("Contador/Contador_todas_questões/Node");
                Contador_classe gete = respe.ResultAs<Contador_classe>();

                MessageBox.Show(gete.Cont);
                var datae = new Data
                {
                    Vestibular = cbovest.Text,
                    ID = (Convert.ToInt32(gete.Cont) + 1).ToString(),
                    Matéria = cbomat.Text,
                    Enunciado = txtquest.Text,
                    Alternativa_A = txta.Text,
                    Alternativa_B = txtb.Text,
                    Alternativa_C = txtc.Text,
                    Alternativa_D = txtd.Text,
                    Alternativa_E = txte.Text,
                    Correta = cbocorreto.Text,
                    Assunto = cboassunto.Text,
                    Img = txtimg.Text,
                };
                SetResponse responsee = await client.SetTaskAsync("Questões/Todas_Questões/" + datae.ID + "/", datae);
                Data resulte = responsee.ResultAs<Data>();
                MessageBox.Show("Questão da " + resulte.Vestibular + " inserida");
                var obje = new Contador_classe
                {
                    Cont = datae.ID
                };
                SetResponse resp1e = await client.SetTaskAsync("Contador/Contador_todas_questões/Node", obje);

            
                    FirebaseResponse respi = await client.GetTaskAsync("Contador/Contador_Assunto "+cboassunto.Text+"/Node");
                    Contador_classe geti = respi.ResultAs<Contador_classe>();

                    MessageBox.Show(geti.Cont);
                    var datai = new Data
                    {
                        Vestibular = cbovest.Text,
                        ID = (Convert.ToInt32(geti.Cont) + 1).ToString(),
                        Matéria = cbomat.Text,
                        Enunciado = txtquest.Text,
                        Alternativa_A = txta.Text,
                        Alternativa_B = txtb.Text,
                        Alternativa_C = txtc.Text,
                        Alternativa_D = txtd.Text,
                        Alternativa_E = txte.Text,
                        Correta = cbocorreto.Text,
                        Assunto = cboassunto.Text,
                        Img = txtimg.Text,

                    };
                    SetResponse responsei = await client.SetTaskAsync("Questões/Assuntos/"+cboassunto.Text+"/" + datai.ID + "/", datai);
                    Data resulti = responsei.ResultAs<Data>();
                    MessageBox.Show("Questão da " + resulti.Vestibular + " inserida");
                    var obji = new Contador_classe
                    {
                        Cont = datai.ID
                    };
                    SetResponse resp1i = await client.SetTaskAsync("Contador/Contador_Assunto " + cboassunto.Text+"/Node", obji);
                
            }
            else
            {
                Erro mostrar = new Erro();
                mostrar.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtquest.Text != "" && txta.Text != "" && txtb.Text != "" && txtc.Text != "" && txtd.Text != "" && txte.Text != "" && cbovest.Text != "")
            {


            }
            else
            {
                Erro mostrar = new Erro();
                mostrar.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtquest.Text = "";
            txta.Text = "";
            txtb.Text = "";
            txtc.Text = "";
            txtd.Text = "";
            txte.Text = "";
            cbovest.Text = "";
            cbomat.Text = "";
            cbocorreto.Text = "";
            cboassunto.Text = "";
            txtimg.Text = "";


        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você quer realmente fechar a aplicação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Dsd_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("CONEXAO");
            }
        }

        private void Cbovest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Button5_Click(object sender, EventArgs e)
        {
            if (cbovest.Text != "" && txtid.Text != "")
            {
                if (cbovest.Text == "Unicamp")
                {
                    FirebaseResponse response = await client.GetTaskAsync("Questões/Unicamp/" + txtid.Text);
                    Data obj = response.ResultAs<Data>();
                    cbovest.Text = obj.Vestibular;
                    txtid.Text = obj.ID;
                    cbomat.Text = obj.Matéria;
                    txtquest.Text = obj.Enunciado;
                    txta.Text = obj.Alternativa_A;
                    txtb.Text = obj.Alternativa_B;
                    txtc.Text = obj.Alternativa_C;
                    txtd.Text = obj.Alternativa_D;
                    txte.Text = obj.Alternativa_E;
                    cbocorreto.Text = obj.Correta;
                    cboassunto.Text = obj.Assunto;
                    txtimg.Text = obj.Img;
                    MessageBox.Show("Dados recuperados");
                }
                if (cbovest.Text == "UNESP")
                {
                    FirebaseResponse response = await client.GetTaskAsync("Questões/UNESP/" + txtid.Text);
                    Data obj = response.ResultAs<Data>();
                    cbovest.Text = obj.Vestibular;
                    txtid.Text = obj.ID;
                    cbomat.Text = obj.Matéria;
                    txtquest.Text = obj.Enunciado;
                    txta.Text = obj.Alternativa_A;
                    txtb.Text = obj.Alternativa_B;
                    txtc.Text = obj.Alternativa_C;
                    txtd.Text = obj.Alternativa_D;
                    txte.Text = obj.Alternativa_E;
                    cbocorreto.Text = obj.Correta;
                    cboassunto.Text = obj.Assunto;
                    txtimg.Text = obj.Img;
                    MessageBox.Show("Dados recuperados");
                }
                if (cbovest.Text == "ENEM")
                {
                    FirebaseResponse response = await client.GetTaskAsync("Questões/ENEM/" + txtid.Text);
                    Data obj = response.ResultAs<Data>();
                    cbovest.Text = obj.Vestibular;
                    txtid.Text = obj.ID;
                    cbomat.Text = obj.Matéria;
                    txtquest.Text = obj.Enunciado;
                    txta.Text = obj.Alternativa_A;
                    txtb.Text = obj.Alternativa_B;
                    txtc.Text = obj.Alternativa_C;
                    txtd.Text = obj.Alternativa_D;
                    txte.Text = obj.Alternativa_E;
                    cbocorreto.Text = obj.Correta;
                    cboassunto.Text = obj.Assunto;
                    txtimg.Text = obj.Img;
                    MessageBox.Show("Dados recuperados");
                }
                if (cbovest.Text == "Fuvest")
                {
                    FirebaseResponse response = await client.GetTaskAsync("Questões/Fuvest/" + txtid.Text);
                    Data obj = response.ResultAs<Data>();
                    cbovest.Text = obj.Vestibular;
                    txtid.Text = obj.ID;
                    cbomat.Text = obj.Matéria;
                    txtquest.Text = obj.Enunciado;
                    txta.Text = obj.Alternativa_A;
                    txtb.Text = obj.Alternativa_B;
                    txtc.Text = obj.Alternativa_C;
                    txtd.Text = obj.Alternativa_D;
                    txte.Text = obj.Alternativa_E;
                    cbocorreto.Text = obj.Correta;
                    cboassunto.Text = obj.Assunto;
                    txtimg.Text = obj.Img;
                    MessageBox.Show("Dados recuperados");
                }

            }
            else
            {
                Erro2 mostrar = new Erro2();
                mostrar.Show();
            }
        }

        private async void Button6_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Vestibular = cbovest.Text,
                ID = txtid.Text,
                Matéria = cbomat.Text,
                Enunciado = txtquest.Text,
                Alternativa_A = txta.Text,
                Alternativa_B = txtb.Text,
                Alternativa_C = txtc.Text,
                Alternativa_D = txtd.Text,
                Alternativa_E = txte.Text,
                Correta = cbocorreto.Text,
                Assunto = cboassunto.Text,
                Img = txtimg.Text,
            };
            if (cbovest.Text != "" && txtid.Text != "")
            {
                if (cbovest.Text == "Unicamp")
                {
                    FirebaseResponse response = await client.UpdateTaskAsync("Questões/Unicamp/" + txtid.Text, data);
                    Data obj = response.ResultAs<Data>();
                    MessageBox.Show("Dados atualizados");
                }
                if (cbovest.Text == "UNESP")
                {
                    FirebaseResponse response = await client.UpdateTaskAsync("Questões/UNESP/" + txtid.Text, data);
                    Data obj = response.ResultAs<Data>();
                    MessageBox.Show("Dados atualizados");
                }
                if (cbovest.Text == "ENEM")
                {
                    FirebaseResponse response = await client.UpdateTaskAsync("Questões/ENEM/" + txtid.Text, data);
                    Data obj = response.ResultAs<Data>();
                    MessageBox.Show("Dados atualizados");
                }
                if (cbovest.Text == "Fuvest")
                {
                    FirebaseResponse response = await client.UpdateTaskAsync("Questões/Fuvest/" + txtid.Text,data);
                    Data obj = response.ResultAs<Data>();
                    MessageBox.Show("Dados atualizados");
                }

            }
            else
            {
                Erro2 mostrar = new Erro2();
                mostrar.Show();
            }
        }

        private async void Button7_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Vestibular = cbovest.Text,
                ID = txtid.Text,
                Matéria = cbomat.Text,
                Enunciado = txtquest.Text,
                Alternativa_A = txta.Text,
                Alternativa_B = txtb.Text,
                Alternativa_C = txtc.Text,
                Alternativa_D = txtd.Text,
                Alternativa_E = txte.Text,
                Correta = cbocorreto.Text,
                Assunto = cboassunto.Text,
                Img = txtimg.Text,
            };
            if (cbovest.Text != "" && txtid.Text != "")
            {
                if (cbovest.Text == "Unicamp")
                {
                    FirebaseResponse response = await client.DeleteTaskAsync("Questões/Unicamp/" + txtid.Text);
                   
                    MessageBox.Show("Dados deletados");
                }
                if (cbovest.Text == "UNESP")
                {
                    FirebaseResponse response = await client.DeleteTaskAsync("Questões/UNESP/" + txtid.Text);
                    
                    MessageBox.Show("Dados deletados");
                }
                if (cbovest.Text == "ENEM")
                {
                    FirebaseResponse response = await client.DeleteTaskAsync("Questões/ENEM/" + txtid.Text);
                   
                    MessageBox.Show("Dados deletados");
                }
                if (cbovest.Text == "Fuvest")
                {
                    FirebaseResponse response = await client.DeleteTaskAsync("Questões/Fuvest/" + txtid.Text);
                    
                    MessageBox.Show("Dados deletados");
                }

            }
            else
            {
                Erro2 mostrar = new Erro2();
                mostrar.Show();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
