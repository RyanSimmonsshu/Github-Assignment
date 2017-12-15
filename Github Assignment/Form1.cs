using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picb_1p_Click(object sender, EventArgs e)
        //This peice of code is used to say if the "picture box" named
        //"picb_1p" is clicked then start the following lines of code.
        {
             if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text =="")
                //This peice of code is used to say if the "text box" "txtb_costpercredit" 
                //"Text property" is set to 0 or empty then 
                //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
                //else means if the data within the "texbox" "text property" 
                //isnt 0 or empty it will allow the folowing code to run and 
                //you wont be stopped by the message box.
            {
                int temp = Convert.ToInt32(lbl_1p.Text);
                //"temp" is a temporary integer created for this process. 
                //This peice of code converts the "lbl_1p" "text property" 
                //from being an string to an integer but it also sets it so the "temp" 
                //integer is equal to the data stored within the labels text.

                temp++;
                //This peice of code makes it so the new "temp" integer adds 1 to the 
                //labels text each time the picture box named "picb_1p" is clicked.

                lbl_1p.Text = temp.ToString();
                //The "labels" "text property" however cant display integers so the data is 
                //converted back to a string with this line of code so it can be displayed 
                //in the "coins entered groupbox".

                temp = Convert.ToInt32(txtb_totalvaluep.Text);
                //This peice of code converts the "txtb_totalvaluep" 
                //"Text property" to an integer. 
                //It now also states that the new value after the last 
                //lines of code have been executed of "temp" are equal to the values stored 
                //within "txtb_totalvaluep" "Text property".

                temp = temp + 1;
                //This peice of code says that the "temp" value will go up by 1 every 
                //time the button is clicked. It does this by adding 1 to the already 
                //existing value of temp so it will gradually go up by 1.

                txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_2p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
                {
                    int temp = Convert.ToInt32(lbl_2p.Text);
                    //"temp" is a temporary integer created for this process. 
                    //This peice of code converts the "lbl_2p" "text property" 
                    //from being an string to an integer but it also sets it so the "temp" 
                    //integer is equal to the data stored within the labels text.

                    temp++;
                    //This peice of code makes it so the new "temp" integer adds 1 to the 
                    //labels text each time the picture box named "picb_2p" is clicked.

                    lbl_2p.Text = temp.ToString();
                    //The "labels" "text property" however cant display integers so the data is 
                    //converted back to a string with this line of code so it can be displayed 
                    //in the "coins entered groupbox".

                    temp = Convert.ToInt32(txtb_totalvaluep.Text);
                    //This peice of code converts the "txtb_totalvaluep" 
                    //"Text property" to an integer. 
                    //It now also states that the new value after the last 
                    //lines of code have been executed of "temp" are equal to the values stored 
                    //within "txtb_totalvaluep" "Text property".

                    temp = temp + 2;
                    //This peice of code says that the "temp" value will go up by 2 every 
                    //time the button is clicked. It does this by adding 2 to the already 
                    //existing value of temp so it will gradually go up by 2.

                    txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_5p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
                    {
                        int temp = Convert.ToInt32(lbl_5p.Text);
                        //"temp" is a temporary integer created for this process. 
                        //This peice of code converts the "lbl_5p" "text property" 
                        //from being an string to an integer but it also sets it so the "temp" 
                        //integer is equal to the data stored within the labels text.

                        temp++;
                        //This peice of code makes it so the new "temp" integer adds 1 to the 
                        //labels text each time the picture box named "picb_5p" is clicked.

                        lbl_5p.Text = temp.ToString();
                        //The "labels" "text property" however cant display integers so the data is 
                        //converted back to a string with this line of code so it can be displayed 
                        //in the "coins entered groupbox".

                        temp = Convert.ToInt32(txtb_totalvaluep.Text);
                        //This peice of code converts the "txtb_totalvaluep" 
                        //"Text property" to an integer. 
                        //It now also states that the new value after the last 
                        //lines of code have been executed of "temp" are equal to the values stored 
                        //within "txtb_totalvaluep" "Text property".

                        temp = temp + 5;
                        //This peice of code says that the "temp" value will go up by 5 every 
                        //time the button is clicked. It does this by adding 5 to the already 
                        //existing value of temp so it will gradually go up by 5.

                        txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_10p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
            {
                int temp = Convert.ToInt32(lbl_10p.Text);
                //"temp" is a temporary integer created for this process. 
                //This peice of code converts the "lbl_10p" "text property" 
                //from being an string to an integer but it also sets it so the "temp" 
                //integer is equal to the data stored within the labels text.

                temp++;
                //This peice of code makes it so the new "temp" integer adds 1 to the 
                //labels text each time the picture box named "picb_10p" is clicked.

                lbl_10p.Text = temp.ToString();
                //The "labels" "text property" however cant display integers so the data is 
                //converted back to a string with this line of code so it can be displayed 
                //in the "coins entered groupbox".

                temp = Convert.ToInt32(txtb_totalvaluep.Text);
                //This peice of code converts the "txtb_totalvaluep" 
                //"Text property" to an integer. 
                //It now also states that the new value after the last 
                //lines of code have been executed of "temp" are equal to the values stored 
                //within "txtb_totalvaluep" "Text property".

                temp = temp + 10;
                //This peice of code says that the "temp" value will go up by 10 every 
                //time the button is clicked. It does this by adding 10 to the already 
                //existing value of temp so it will gradually go up by 10.

                txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_20p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
            {
                int temp = Convert.ToInt32(lbl_20p.Text);
                //"temp" is a temporary integer created for this process. 
                //This peice of code converts the "lbl_20p" "text property" 
                //from being an string to an integer but it also sets it so the "temp" 
                //integer is equal to the data stored within the labels text.

                temp++;
                //This peice of code makes it so the new "temp" integer adds 1 to the 
                //labels text each time the picture box named "picb_20p" is clicked.

                lbl_20p.Text = temp.ToString();
                //The "labels" "text property" however cant display integers so the data is 
                //converted back to a string with this line of code so it can be displayed 
                //in the "coins entered groupbox".

                temp = Convert.ToInt32(txtb_totalvaluep.Text);
                //This peice of code converts the "txtb_totalvaluep" 
                //"Text property" to an integer. 
                //It now also states that the new value after the last 
                //lines of code have been executed of "temp" are equal to the values stored 
                //within "txtb_totalvaluep" "Text property".

                temp = temp + 20;
                //This peice of code says that the "temp" value will go up by 20 every 
                //time the button is clicked. It does this by adding 20 to the already 
                //existing value of temp so it will gradually go up by 20.

                txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_50p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
            {
                int temp = Convert.ToInt32(lbl_50p.Text);
                //"temp" is a temporary integer created for this process. 
                //This peice of code converts the "lbl_50p" "text property" 
                //from being an string to an integer but it also sets it so the "temp" 
                //integer is equal to the data stored within the labels text.

                temp++;
                //This peice of code makes it so the new "temp" integer adds 1 to the 
                //labels text each time the picture box named "picb_50p" is clicked.

                lbl_50p.Text = temp.ToString();
                //The "labels" "text property" however cant display integers so the data is 
                //converted back to a string with this line of code so it can be displayed 
                //in the "coins entered groupbox".

                temp = Convert.ToInt32(txtb_totalvaluep.Text);
                //This peice of code converts the "txtb_totalvaluep" 
                //"Text property" to an integer. 
                //It now also states that the new value after the last 
                //lines of code have been executed of "temp" are equal to the values stored 
                //within "txtb_totalvaluep" "Text property".

                temp = temp + 50;
                //This peice of code says that the "temp" value will go up by 50 every 
                //time the button is clicked. It does this by adding 50 to the already 
                //existing value of temp so it will gradually go up by 50.

                txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_100p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
            {
                int temp = Convert.ToInt32(lbl_100p.Text);
                //"temp" is a temporary integer created for this process. 
                //This peice of code converts the "lbl_100p" "text property" 
                //from being an string to an integer but it also sets it so the "temp" 
                //integer is equal to the data stored within the labels text.

                temp++;
                //This peice of code makes it so the new "temp" integer adds 1 to the 
                //labels text each time the picture box named "picb_100p" is clicked.

                lbl_100p.Text = temp.ToString();
                //The "labels" "text property" however cant display integers so the data is 
                //converted back to a string with this line of code so it can be displayed 
                //in the "coins entered groupbox".

                temp = Convert.ToInt32(txtb_totalvaluep.Text);
                //This peice of code converts the "txtb_totalvaluep" 
                //"Text property" to an integer. 
                //It now also states that the new value after the last 
                //lines of code have been executed of "temp" are equal to the values stored 
                //within "txtb_totalvaluep" "Text property".

                temp = temp + 100;
                //This peice of code says that the "temp" value will go up by 100 every 
                //time the button is clicked. It does this by adding 100 to the already 
                //existing value of temp so it will gradually go up by 100.

                txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void picb_200p_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")
            //This peice of code is used to say if the "text box" "txtb_costpercredit" 
            //"Text property" is set to 0 or empty then 
            //it will execute the next line of code.
            {
                MessageBox.Show("Please input a cost per credit");
                //This peice of code creates a message which will appear in a 
                //seperate window stating that the user needs to input a
                //cost per credit into the "textbox" "txtb_cospercredit"
            }
            else
            //else means if the data within the "texbox" "text property" 
            //isnt 0 or empty it will allow the folowing code to run and 
            //you wont be stopped by the message box.
            {
                int temp = Convert.ToInt32(lbl_200p.Text);
                //"temp" is a temporary integer created for this process. 
                //This peice of code converts the "lbl_200p" "text property" 
                //from being an string to an integer but it also sets it so the "temp" 
                //integer is equal to the data stored within the labels text.

                temp++;
                //This peice of code makes it so the new "temp" integer adds 1 to the 
                //labels text each time the picture box named "picb_200p" is clicked.

                lbl_200p.Text = temp.ToString();
                //The "labels" "text property" however cant display integers so the data is 
                //converted back to a string with this line of code so it can be displayed 
                //in the "coins entered groupbox".

                temp = Convert.ToInt32(txtb_totalvaluep.Text);
                //This peice of code converts the "txtb_totalvaluep" 
                //"Text property" to an integer. 
                //It now also states that the new value after the last 
                //lines of code have been executed of "temp" are equal to the values stored 
                //within "txtb_totalvaluep" "Text property".

                temp = temp + 200;
                //This peice of code says that the "temp" value will go up by 200 every 
                //time the button is clicked. It does this by adding 200 to the already 
                //existing value of temp so it will gradually go up by 200.

                txtb_totalvaluep.Text = temp.ToString();
                //This code converts the "txtb_totalvaluep.Text" value back into a 
                //string so it can be displayed as integers cant be displayed through text.

                txtb_topounds.Text = String.Format("{0:n2}", (Convert.ToDouble(txtb_totalvaluep.Text) / 100));
                //This line of code now changes the format in which the "txtb_totalvaluep.Text" 
                //is displayed and places it within the "txtb_topounds.Text". 
                //It does this by showing how it should be displayed "{0:n2}" and then 
                //converting the "txtb_totalvaluep.Text" into a double then dividing it by 100.

                int holdvalue = (Convert.ToInt32(txtb_totalvaluep.Text)) / (Convert.ToInt32(txtb_costpercredit.Text));
                //A new integer it made to take in the calculation gained from the before line of 
                //code and then divides it by the value placed within "txtb_costpercredit.Text". 
                //It does this by converting them into integers first so they can be placed into a calculation.

                textBoxcredits.Text = holdvalue.ToString();
                //The "int holdvalue" stores the calculation created from the before 
                //line of code and then coverts the value being held back into a string
                //where it is outputted through the "textBoxcredits" Text property.
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBoxcredits.Text = "0";
            txtb_costpercredit.Text = "0";
            txtb_topounds.Text = "0";
            txtb_totalvaluep.Text = "0";
            lbl_1p.Text = "0";
            lbl_2p.Text = "0";
            lbl_5p.Text = "0";
            lbl_10p.Text = "0";
            lbl_20p.Text = "0";
            lbl_50p.Text = "0";
            lbl_100p.Text = "0";
            lbl_200p.Text = "0";
            //these lines of code are very simple and all they do is when you click the reset button "button1_Click" it changes the values of all the
            //Text properties for these text boxes and labels to 0
            //This means you are effectively resetting all of the values to their default or values that have no impact on the application
            //apart from not allowing you to calculate credits with a message box like what was shown in the "picb_1p_Click" code.
        }
    }
}
