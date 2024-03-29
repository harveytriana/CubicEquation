﻿namespace CubicEquation
{
    partial class FormMain
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
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelEquation = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelD);
            this.groupBoxInput.Controls.Add(this.labelC);
            this.groupBoxInput.Controls.Add(this.labelB);
            this.groupBoxInput.Controls.Add(this.labelA);
            this.groupBoxInput.Controls.Add(this.textBoxD);
            this.groupBoxInput.Controls.Add(this.textBoxC);
            this.groupBoxInput.Controls.Add(this.textBoxB);
            this.groupBoxInput.Controls.Add(this.textBoxA);
            this.groupBoxInput.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInput.Location = new System.Drawing.Point(25, 92);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(200, 136);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(15, 101);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(24, 15);
            this.labelD.TabIndex = 16;
            this.labelD.Text = "d =";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(15, 74);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(23, 15);
            this.labelC.TabIndex = 15;
            this.labelC.Text = "c =";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(15, 48);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(24, 15);
            this.labelB.TabIndex = 14;
            this.labelB.Text = "b =";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(15, 22);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(23, 15);
            this.labelA.TabIndex = 13;
            this.labelA.Text = "a =";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(55, 97);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(116, 22);
            this.textBoxD.TabIndex = 12;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(55, 71);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(116, 22);
            this.textBoxC.TabIndex = 11;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(55, 45);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(116, 22);
            this.textBoxB.TabIndex = 10;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(55, 19);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(116, 22);
            this.textBoxA.TabIndex = 9;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelX3);
            this.groupBoxOutput.Controls.Add(this.labelX2);
            this.groupBoxOutput.Controls.Add(this.labelX1);
            this.groupBoxOutput.Controls.Add(this.textBoxX3);
            this.groupBoxOutput.Controls.Add(this.textBoxX2);
            this.groupBoxOutput.Controls.Add(this.textBoxX1);
            this.groupBoxOutput.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOutput.Location = new System.Drawing.Point(247, 92);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(209, 106);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(15, 74);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(28, 15);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "x3 =";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(15, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(28, 15);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "x2 =";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(15, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(28, 15);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "x1 =";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(51, 71);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(143, 22);
            this.textBoxX3.TabIndex = 18;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(51, 45);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(143, 22);
            this.textBoxX2.TabIndex = 17;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(51, 19);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(143, 22);
            this.textBoxX1.TabIndex = 16;
            // 
            // labelEquation
            // 
            this.labelEquation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEquation.Location = new System.Drawing.Point(25, 60);
            this.labelEquation.Name = "labelEquation";
            this.labelEquation.Size = new System.Drawing.Size(431, 29);
            this.labelEquation.TabIndex = 6;
            this.labelEquation.Text = "ax^3 + bx^2 + cx + d = 0";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle.Location = new System.Drawing.Point(25, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(489, 29);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Cubic Equation";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(25, 238);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(200, 25);
            this.buttonExecute.TabIndex = 10;
            this.buttonExecute.Text = "Calculate";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Enabled = false;
            this.buttonValidate.Location = new System.Drawing.Point(247, 238);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(209, 25);
            this.buttonValidate.TabIndex = 11;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBoxSave.Checked = true;
            this.checkBoxSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSave.Location = new System.Drawing.Point(379, 211);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(77, 17);
            this.checkBoxSave.TabIndex = 12;
            this.checkBoxSave.Text = "Remember";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 281);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelEquation);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cubic Equation";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelEquation;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.CheckBox checkBoxSave;
    }
}

