using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace complenList
{
    public partial class ComplainUI : Form
    {
        public ComplainUI()
        {
            InitializeComponent();
        }
       

        //Queue<string> _complains = new Queue<string>();
        //Queue<string> _names = new Queue<string>();
        //Qu eue<string> _addresses = new Queue<string>();
        //Queue<string>  _phoneNumbers= new Queue<string>();
        //Queue<int> _results=new Queue<int>(); 

        //update----------------
       
      

        string name = "";
        string complain = "";
        string address="";
        string phone = "";
        int sl = 0;
        private int result = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            addComplainButton.Focus();
        }
        Queue<Complain> complinQueue = new Queue<Complain>();
        Queue<string> Compla = new Queue<string>();

       // Complain aComplain = new Complain();
    
        private void addComplainButton_Click(object sender, EventArgs e)
        {
            Complain aComplain = new Complain();
          
       DateTime date=new DateTime();
     
       string dateNow = Convert.ToString(DateTime.Now);
          
            
            //_complains.Enqueue( textBoxForInputComplain.Text);
            //_names.Enqueue( textBoxForInputName.Text);
            //_addresses.Enqueue(textBoxForInputAddress.Text);
            //_phoneNumbers.Enqueue(textBoxForPhone.Text);
           //_results.Enqueue(++sl);

            //UpDate------------------------------
            aComplain.slNo = ++result;
            aComplain.complian = textBoxForInputComplain.Text;
            aComplain.name = textBoxForInputName.Text;
            aComplain.address = textBoxForInputAddress.Text;
            aComplain.phone = textBoxForPhone.Text;
            aComplain.dateNow = dateNow;
            
           // Compla.Enqueue(textBoxForInputName.Text);
            if (textBoxForInputComplain.Text=="")
            {
                MessageBox.Show("you have no complain!!");
                goto End;
            }
            else if (textBoxForInputName.Text == "")
            {
                MessageBox.Show("Please Entry complainer Name!!");
                goto End;
            }
            else
            {
                complinQueue.Enqueue(aComplain);
            }
             

            /*
            // listBoxForComplinMakeQueue.Items.Clear();
            foreach (int _result in _results)
            {   
                this.result = _result;
            }
           foreach(string _complain in _complains){
               complain = _complain;
                // listBoxForComplinMakeQueue.Items.Add(_complain);  
            }          
           foreach (string _name in _names){
               name = _name;
               //listBoxForComplinMakeQueue.Items.Add(_name);
             }
           foreach (string _address in _addresses)
           {
               address = _address;
               //listBoxForComplinMakeQueue.Items.Add(_address);
           }
         
           foreach (string _phone in _phoneNumbers)
           {

               phone = _phone;
               //listBoxForComplinMakeQueue.Items.Add(_address);
           }
          */

            //UpDate code-----------------------------

             listView1.Items.Clear();
            foreach (Complain eachComplain in complinQueue)
            {
                //listView1.Items.Clear();
                ListViewItem listiItem = new ListViewItem(); 
                listiItem.Text = eachComplain.slNo.ToString();
                listiItem.SubItems.Add(eachComplain.complian);
                listiItem.SubItems.Add(eachComplain.name);
                listiItem.SubItems.Add(eachComplain.address);
                listiItem.SubItems.Add(eachComplain.phone);
                listiItem.SubItems.Add(eachComplain.dateNow);
                listView1.Items.Add(listiItem);
               
            }
          

        //   listBoxForComplinMakeQueue.Items.Add("Complain: "+complain+"\t Name:"+name+"\t Address:"+address ); 
           // ListViewItem item = new ListViewItem(result.ToString());
           //item.SubItems.Add(complain);
           //item.SubItems.Add(name);
           //item.SubItems.Add(address);
           //item.SubItems.Add(phone);

          // listView1.Items.Add(item);

           textBoxForInputComplain.Text = "";
           textBoxForInputName.Text = "";
           textBoxForInputAddress.Text = "";
           textBoxForPhone.Text = "";
         End:;

        }

        private void reMoveComplainButton_Click(object sender, EventArgs e)
        {
            ////listView1.Items.Clear();
            Complain fa = new Complain();
      
            if (listView1.Items.Count!=0)
            {
                fa = complinQueue.Dequeue();

                textBoxForOutputSerialNumber.Text = fa.slNo.ToString();
                textBoxForOutputComplain.Text = fa.complian;
                textBoxForOutputName.Text = fa.name;
                textBoxForOutputAddress.Text = fa.address;
             

            }
            else
            {
                MessageBox.Show("No Waiting Any Complian!!!!!!!!!!");
            }
            



            listView1.Items.Clear();
            foreach (Complain eachComplain in complinQueue)
            {
                
                ListViewItem listiItem = new ListViewItem();
                listiItem.Text = eachComplain.slNo.ToString();
                listiItem.SubItems.Add(eachComplain.complian);
                listiItem.SubItems.Add(eachComplain.name);
                listiItem.SubItems.Add(eachComplain.address);
                listiItem.SubItems.Add(eachComplain.phone);
                listiItem.SubItems.Add(eachComplain.dateNow);
                listView1.Items.Add(listiItem);

            }
           

            //----------------------------------------------------------
       //    textBoxForOutputAddress.Text = aComplain.slNo.ToString();
          // var dats= complinQueue.Dequeue();
          //textBoxForOutputSerialNumber.Text = dats.slNo.ToString();


            /*    
            textBoxForOutputComplain.Text = _complains.Dequeue();
            textBoxForOutputName.Text= _names.Dequeue();
            textBoxForOutputAddress.Text = _addresses.Dequeue();
            _phoneNumbers.Dequeue();
            textBoxForOutputSerialNumber.Text = _results.Dequeue().ToString();

            ListViewItem item = new ListViewItem();
            foreach (int _result in _results)
            {
               item.Text= _result.ToString();
            }
           

            foreach (string _complain in _complains)
            {
                
                item.SubItems.Add(_complain);
               // complain = _complain;
                // listBoxForComplinMakeQueue.Items.Add(_complain);  
            }
            foreach (string _name in _names)
            {
                item.SubItems.Add(_name);
                //listBoxForComplinMakeQueue.Items.Add(_name);
            }
            foreach (string _address in _addresses)
            {
                item.SubItems.Add(_address);
                //listBoxForComplinMakeQueue.Items.Add(_address);
            }
          
            foreach (string _phone in _phoneNumbers)
            {
                item.SubItems.Add(_phone);
                //listBoxForComplinMakeQueue.Items.Add(_address);
            }
            listView1.Items.Add(item);

            //textBoxForOutputComplain.Text = "";
            //textBoxForOutputName.Text= "";
            //textBoxForOutputAddress.Text = "";
       */


        }

        private void label9_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("http://www.google.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("please check your internet connection");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
