using OutOfClassAssignment2.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OutOfClassAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            int celebSelect; 
            if (listBoxCeleb.SelectedIndex != -1)
            {
                celebSelect = listBoxCeleb.SelectedIndex;

                switch (celebSelect)
                {
                    case 0:

                        pictureBoxCeleb.BackgroundImage = Resources.images;

                        if (radbttnSmoking.Checked)
                        {
                            lblQuote.Text =
                                  " I love them. Love Them. I think the more positive approach you have to smoking, the less harmful it is. - Sienna Miller ";
                         
                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font (lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        if (radbttnCeleb.Checked)
                        {
                            lblQuote.Text = "I have had, and am having, such a lovely life. - Sienna Miller";


                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        if (radbttnThoughts.Checked)
                        {
                            lblQuote.Text = " I've always kind of done exactly what my instincts said. - Sienna Miller";


                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        
                        break;

                    case 1:

                        pictureBoxCeleb.BackgroundImage = Resources.brooke;

                        if (radbttnSmoking.Checked)
                        {
                            lblQuote.Text =
                                  " Smoking kills. If you're killed, you've lost an important part of your life.  - Brooke Shields";


                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        if (radbttnCeleb.Checked)
                        {
                            lblQuote.Text = 
                                "Once when my mother mentioned an amount and I realized I didn't understand, " +
                                "she had to explain: 'That's like three Mercedes.' Then I understood. - Brooke Shields";

                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        if (radbttnThoughts.Checked)
                        {
                            lblQuote.Text = " If my jeans could talk... would I be embarrassed?  - Brooke Shields";


                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }

                        break;

                    case 2:

                        pictureBoxCeleb.BackgroundImage = Resources.download;

                        if (radbttnSmoking.Checked)
                        {
                            lblQuote.Text =
                                  "None of my friends smoke. I've never smoked a cigarette in my life. - Justin Bieber";

                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        if (radbttnCeleb.Checked)
                        {
                            lblQuote.Text =
                                "I'm not sure about [political] parties. But whatever they have in Korea, that's bad. - Justin Bieber";


                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }
                        if (radbttnThoughts.Checked)
                        {
                            lblQuote.Text =
                                " You don't need to go to church to be a Christian. " +
                                "If you go to Taco Bell, that doesn't make you a taco. - Justin Bieber";


                            if (chckBoxBold.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Bold);
                            }
                            if (chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic);
                            }
                            if (chckBoxBold.Checked & chckBoxFancy.Checked)
                            {
                                lblQuote.Font = new Font(lblQuote.Font.Name, 14, FontStyle.Italic | FontStyle.Bold);
                            }

                        }

                        break;



                }
            }
           
        }
    }
}
