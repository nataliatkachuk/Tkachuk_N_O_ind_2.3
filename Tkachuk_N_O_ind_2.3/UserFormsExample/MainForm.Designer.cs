/*
 * Created by SharpDevelop.
 * User: Yuriy
 * Date: 06.05.2020
 * Time: 10:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UserFormsExample
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button AddRecordButton;
		private System.Windows.Forms.Button PreviousRecordbutton;
		private System.Windows.Forms.Button NextRecordButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TBMark;
		private System.Windows.Forms.TextBox TBModel;
		private System.Windows.Forms.TextBox TBNomer;
		private System.Windows.Forms.TextBox NDWay;
		private System.Windows.Forms.Button SaveListButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label totalObjects;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.AddRecordButton = new System.Windows.Forms.Button();
			this.PreviousRecordbutton = new System.Windows.Forms.Button();
			this.NextRecordButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TBMark = new System.Windows.Forms.TextBox();
			this.TBModel = new System.Windows.Forms.TextBox();
			this.TBNomer = new System.Windows.Forms.TextBox();
			this.NDWay = new System.Windows.Forms.TextBox();
			this.SaveListButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.totalObjects = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TBSitplace = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// AddRecordButton
			// 
			this.AddRecordButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddRecordButton.Location = new System.Drawing.Point(209, 285);
			this.AddRecordButton.Margin = new System.Windows.Forms.Padding(6);
			this.AddRecordButton.Name = "AddRecordButton";
			this.AddRecordButton.Size = new System.Drawing.Size(354, 100);
			this.AddRecordButton.TabIndex = 0;
			this.AddRecordButton.Text = "ADD";
			this.AddRecordButton.UseVisualStyleBackColor = true;
			this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButtonClick);
			// 
			// PreviousRecordbutton
			// 
			this.PreviousRecordbutton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PreviousRecordbutton.Location = new System.Drawing.Point(45, 285);
			this.PreviousRecordbutton.Margin = new System.Windows.Forms.Padding(6);
			this.PreviousRecordbutton.Name = "PreviousRecordbutton";
			this.PreviousRecordbutton.Size = new System.Drawing.Size(138, 100);
			this.PreviousRecordbutton.TabIndex = 1;
			this.PreviousRecordbutton.Text = "<<";
			this.PreviousRecordbutton.UseVisualStyleBackColor = true;
			this.PreviousRecordbutton.Click += new System.EventHandler(this.PreviousRecordbuttonClick);
			// 
			// NextRecordButton
			// 
			this.NextRecordButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NextRecordButton.Location = new System.Drawing.Point(575, 285);
			this.NextRecordButton.Margin = new System.Windows.Forms.Padding(6);
			this.NextRecordButton.Name = "NextRecordButton";
			this.NextRecordButton.Size = new System.Drawing.Size(138, 100);
			this.NextRecordButton.TabIndex = 2;
			this.NextRecordButton.Text = ">>";
			this.NextRecordButton.UseVisualStyleBackColor = true;
			this.NextRecordButton.Click += new System.EventHandler(this.NextRecordButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 34);
			this.label1.TabIndex = 3;
			this.label1.Text = "Марка";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 34);
			this.label2.TabIndex = 4;
			this.label2.Text = "Модель";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 34);
			this.label3.TabIndex = 5;
			this.label3.Text = "Номер";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 34);
			this.label4.TabIndex = 6;
			this.label4.Text = "Шлях";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// TBMark
			// 
			this.TBMark.Location = new System.Drawing.Point(209, 40);
			this.TBMark.Name = "TBMark";
			this.TBMark.Size = new System.Drawing.Size(125, 34);
			this.TBMark.TabIndex = 7;
			// 
			// TBModel
			// 
			this.TBModel.Location = new System.Drawing.Point(209, 97);
			this.TBModel.Name = "TBModel";
			this.TBModel.Size = new System.Drawing.Size(125, 34);
			this.TBModel.TabIndex = 8;
			// 
			// TBNomer
			// 
			this.TBNomer.Location = new System.Drawing.Point(209, 149);
			this.TBNomer.Name = "TBNomer";
			this.TBNomer.Size = new System.Drawing.Size(125, 34);
			this.TBNomer.TabIndex = 9;
			// 
			// NDWay
			// 
			this.NDWay.Location = new System.Drawing.Point(209, 211);
			this.NDWay.Name = "NDWay";
			this.NDWay.Size = new System.Drawing.Size(125, 34);
			this.NDWay.TabIndex = 10;
			// 
			// SaveListButton
			// 
			this.SaveListButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveListButton.Location = new System.Drawing.Point(209, 438);
			this.SaveListButton.Margin = new System.Windows.Forms.Padding(6);
			this.SaveListButton.Name = "SaveListButton";
			this.SaveListButton.Size = new System.Drawing.Size(354, 100);
			this.SaveListButton.TabIndex = 11;
			this.SaveListButton.Text = "SAVE";
			this.SaveListButton.UseVisualStyleBackColor = true;
			this.SaveListButton.Click += new System.EventHandler(this.SaveListButtonClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(45, 409);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Total Objects";
			// 
			// totalObjects
			// 
			this.totalObjects.Location = new System.Drawing.Point(209, 409);
			this.totalObjects.Name = "totalObjects";
			this.totalObjects.Size = new System.Drawing.Size(79, 23);
			this.totalObjects.TabIndex = 13;
			this.totalObjects.Text = "Total Objects";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(387, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(182, 68);
			this.label6.TabIndex = 14;
			this.label6.Text = "Місця сидіння";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// TBSitplace
			// 
			this.TBSitplace.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TBSitplace.Location = new System.Drawing.Point(575, 40);
			this.TBSitplace.Name = "TBSitplace";
			this.TBSitplace.Size = new System.Drawing.Size(125, 34);
			this.TBSitplace.TabIndex = 17;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 553);
			this.Controls.Add(this.TBSitplace);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.totalObjects);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.SaveListButton);
			this.Controls.Add(this.NDWay);
			this.Controls.Add(this.TBNomer);
			this.Controls.Add(this.TBModel);
			this.Controls.Add(this.TBMark);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NextRecordButton);
			this.Controls.Add(this.PreviousRecordbutton);
			this.Controls.Add(this.AddRecordButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.Text = "UserFormsExample";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBSitplace;
    }
}
