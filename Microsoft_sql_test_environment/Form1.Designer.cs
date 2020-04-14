namespace Microsoft_sql_test_environment
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_ReadJson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Table_Users = new System.Windows.Forms.TableLayoutPanel();
            this.Button_GetTop = new System.Windows.Forms.Button();
            this.Button_GetRowCount = new System.Windows.Forms.Button();
            this.Button_GetDivisionResult = new System.Windows.Forms.Button();
            this.Button_GetConcatenationResult = new System.Windows.Forms.Button();
            this.Button_SelectExcept = new System.Windows.Forms.Button();
            this.Button_SelectReplace = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_ReadJson
            // 
            this.Button_ReadJson.Location = new System.Drawing.Point(906, 663);
            this.Button_ReadJson.Name = "Button_ReadJson";
            this.Button_ReadJson.Size = new System.Drawing.Size(242, 58);
            this.Button_ReadJson.TabIndex = 0;
            this.Button_ReadJson.Text = "Read Json";
            this.Button_ReadJson.UseVisualStyleBackColor = true;
            this.Button_ReadJson.Click += new System.EventHandler(this.Button_ReadJson_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Table_Users);
            this.panel1.Location = new System.Drawing.Point(523, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 800);
            this.panel1.MinimumSize = new System.Drawing.Size(100, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 200);
            this.panel1.TabIndex = 1;
            // 
            // Table_Users
            // 
            this.Table_Users.AutoSize = true;
            this.Table_Users.ColumnCount = 5;
            this.Table_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table_Users.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table_Users.Location = new System.Drawing.Point(13, 4);
            this.Table_Users.Name = "Table_Users";
            this.Table_Users.RowCount = 2;
            this.Table_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_Users.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_Users.Size = new System.Drawing.Size(500, 100);
            this.Table_Users.TabIndex = 0;
            // 
            // Button_GetTop
            // 
            this.Button_GetTop.Location = new System.Drawing.Point(31, 663);
            this.Button_GetTop.Name = "Button_GetTop";
            this.Button_GetTop.Size = new System.Drawing.Size(242, 58);
            this.Button_GetTop.TabIndex = 2;
            this.Button_GetTop.Text = "Get Top 50000";
            this.Button_GetTop.UseVisualStyleBackColor = true;
            this.Button_GetTop.Click += new System.EventHandler(this.Button_GetTop_Click);
            // 
            // Button_GetRowCount
            // 
            this.Button_GetRowCount.Location = new System.Drawing.Point(340, 663);
            this.Button_GetRowCount.Name = "Button_GetRowCount";
            this.Button_GetRowCount.Size = new System.Drawing.Size(242, 58);
            this.Button_GetRowCount.TabIndex = 3;
            this.Button_GetRowCount.Text = "Get Row Count 50000";
            this.Button_GetRowCount.UseVisualStyleBackColor = true;
            this.Button_GetRowCount.Click += new System.EventHandler(this.Button_GetRowCount_Click);
            // 
            // Button_GetDivisionResult
            // 
            this.Button_GetDivisionResult.Location = new System.Drawing.Point(619, 663);
            this.Button_GetDivisionResult.Name = "Button_GetDivisionResult";
            this.Button_GetDivisionResult.Size = new System.Drawing.Size(242, 58);
            this.Button_GetDivisionResult.TabIndex = 4;
            this.Button_GetDivisionResult.Text = "Get Division Result";
            this.Button_GetDivisionResult.UseVisualStyleBackColor = true;
            this.Button_GetDivisionResult.Click += new System.EventHandler(this.Button_GetDivisionResult_Click);
            // 
            // Button_GetConcatenationResult
            // 
            this.Button_GetConcatenationResult.Location = new System.Drawing.Point(619, 577);
            this.Button_GetConcatenationResult.Name = "Button_GetConcatenationResult";
            this.Button_GetConcatenationResult.Size = new System.Drawing.Size(242, 58);
            this.Button_GetConcatenationResult.TabIndex = 5;
            this.Button_GetConcatenationResult.Text = "Get String Concatenation Result";
            this.Button_GetConcatenationResult.UseVisualStyleBackColor = true;
            this.Button_GetConcatenationResult.Click += new System.EventHandler(this.Button_GetConcatenationResult_Click);
            // 
            // Button_SelectExcept
            // 
            this.Button_SelectExcept.Location = new System.Drawing.Point(31, 577);
            this.Button_SelectExcept.Name = "Button_SelectExcept";
            this.Button_SelectExcept.Size = new System.Drawing.Size(242, 58);
            this.Button_SelectExcept.TabIndex = 6;
            this.Button_SelectExcept.Text = "Get Except Result";
            this.Button_SelectExcept.UseVisualStyleBackColor = true;
            this.Button_SelectExcept.Click += new System.EventHandler(this.Button_SelectExcept_Click);
            // 
            // Button_SelectReplace
            // 
            this.Button_SelectReplace.Location = new System.Drawing.Point(340, 577);
            this.Button_SelectReplace.Name = "Button_SelectReplace";
            this.Button_SelectReplace.Size = new System.Drawing.Size(242, 58);
            this.Button_SelectReplace.TabIndex = 7;
            this.Button_SelectReplace.Text = "Get Replace Result";
            this.Button_SelectReplace.UseVisualStyleBackColor = true;
            this.Button_SelectReplace.Click += new System.EventHandler(this.Button_SelectReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 754);
            this.Controls.Add(this.Button_SelectReplace);
            this.Controls.Add(this.Button_SelectExcept);
            this.Controls.Add(this.Button_GetConcatenationResult);
            this.Controls.Add(this.Button_GetDivisionResult);
            this.Controls.Add(this.Button_GetRowCount);
            this.Controls.Add(this.Button_GetTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_ReadJson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ReadJson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel Table_Users;
        private System.Windows.Forms.Button Button_GetTop;
        private System.Windows.Forms.Button Button_GetRowCount;
        private System.Windows.Forms.Button Button_GetDivisionResult;
        private System.Windows.Forms.Button Button_GetConcatenationResult;
        private System.Windows.Forms.Button Button_SelectExcept;
        private System.Windows.Forms.Button Button_SelectReplace;
    }
}

