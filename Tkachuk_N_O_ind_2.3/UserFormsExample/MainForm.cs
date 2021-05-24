using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UserFormsExample
{

	public partial class MainForm : Form
	{
		List<car> recordList;
		car currentRecord;
		int totalRecords=0;
		int currentRecordIndex=-1;
		public MainForm()
		{

			InitializeComponent();
			recordList=new List <car>();
			
		}
		private void BindToForm()
		{
			TBSitplace.Text = currentRecord.sitplace.ToString();
			TBMark.Text = currentRecord.Mark;
			TBModel.Text = currentRecord.Model;
			TBNomer.Text = currentRecord.nomer;
			NDWay.Text = currentRecord.way;
		}
		private void BindToObject()
		{
			currentRecord.sitplace = Byte.Parse(TBSitplace.Text);
			currentRecord.Mark = TBMark.Text;
			currentRecord.Model = TBModel.Text;
			currentRecord.nomer = TBNomer.Text;
			currentRecord.way = NDWay.Text;
		}
		void AddRecordButtonClick(object sender, EventArgs e)
		{
			if(currentRecord!=null)
				BindToObject();
            totalRecords++;
            currentRecord=new car();
            BindToForm();
            recordList.Add(currentRecord);
            currentRecordIndex=totalRecords-1;
            totalObjects.Text=totalRecords.ToString();
		}
		void PreviousRecordbuttonClick(object sender, EventArgs e)
		{
			if(currentRecord!=null)
				BindToObject();
			if(currentRecordIndex>0)
		    {
				currentRecordIndex--;
                currentRecord=recordList[currentRecordIndex];
                BindToForm();
            }
		}

		void NextRecordButtonClick(object sender, EventArgs e)
		{
			if(currentRecord!=null)
				BindToObject();
            if(currentRecordIndex<totalRecords-1)
            {
            	currentRecordIndex++;
                currentRecord=recordList[currentRecordIndex];
                BindToForm();
            }
		}
		void SaveListButtonClick(object sender, EventArgs e)
		{
			SaveFileDialog FwFile = new SaveFileDialog();
			FwFile.DefaultExt = ".fw";
			FwFile.Filter = "fw data file (*.fw) *.fw|";
			if (FwFile.ShowDialog() == DialogResult.OK)
            {
				
				StreamWriter FwFilewrite = new StreamWriter(FwFile.FileName);

				FwFilewrite.Write(TBMark.Text + " " + TBModel.Text + " " + TBNomer.Text + " " + NDWay.Text + " " + TBSitplace.Text );

				FwFilewrite.Close();
            }
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
