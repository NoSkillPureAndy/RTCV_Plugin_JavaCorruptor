﻿namespace JAVACORRUPTOR.UI.Components.EngineControls
{
    partial class JavaCustomEngineControl : JavaEngineControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.engineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // engineGroupBox
            // 
            this.engineGroupBox.Controls.Add(this.btnLoad);
            this.engineGroupBox.Controls.Add(this.btnSaveAs);
            this.engineGroupBox.Controls.Add(this.tbReplace);
            this.engineGroupBox.Controls.Add(this.btnSave);
            this.engineGroupBox.Controls.Add(this.tbFind);
            this.engineGroupBox.Controls.Add(this.label2);
            this.engineGroupBox.Controls.Add(this.label1);
            this.engineGroupBox.Controls.Add(this.label19);
            this.engineGroupBox.Controls.SetChildIndex(this.label19, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.placeholderComboBox, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.label1, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.label2, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.tbFind, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.btnSave, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.tbReplace, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.btnSaveAs, 0);
            this.engineGroupBox.Controls.SetChildIndex(this.btnLoad, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(169, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(196, 13);
            this.label19.TabIndex = 148;
            this.label19.Text = "You must save or load before corrupting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 159;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "Replace";
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.tbFind.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbFind.ForeColor = System.Drawing.Color.White;
            this.tbFind.Location = new System.Drawing.Point(7, 51);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(175, 91);
            this.tbFind.TabIndex = 162;
            this.tbFind.Tag = "color:normal";
            this.tbFind.Text = "// Find any add instruction\r\n<(I|L|F|D)>ADD";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(41, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 20);
            this.btnSave.TabIndex = 163;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "color:light1";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbReplace
            // 
            this.tbReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.tbReplace.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbReplace.ForeColor = System.Drawing.Color.White;
            this.tbReplace.Location = new System.Drawing.Point(188, 51);
            this.tbReplace.Multiline = true;
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(175, 91);
            this.tbReplace.TabIndex = 164;
            this.tbReplace.Tag = "color:normal";
            this.tbReplace.Text = "// Replace it with subtraction\r\n// and multiply by 2 \r\n<$0>SUB\r\nLDC 2<$0>\r\n<$0>MU" +
    "L";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAs.BackColor = System.Drawing.Color.Gray;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.Location = new System.Drawing.Point(112, 29);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(65, 20);
            this.btnSaveAs.TabIndex = 165;
            this.btnSaveAs.TabStop = false;
            this.btnSaveAs.Tag = "color:light1";
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.Gray;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(193, 29);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 20);
            this.btnLoad.TabIndex = 166;
            this.btnLoad.TabStop = false;
            this.btnLoad.Tag = "color:light1";
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // JavaCustomEngineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "JavaCustomEngineControl";
            this.engineGroupBox.ResumeLayout(false);
            this.engineGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}