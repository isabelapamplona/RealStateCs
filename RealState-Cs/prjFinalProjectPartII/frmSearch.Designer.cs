
namespace prjFinalProjectPartII
{
    partial class frmSearch
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
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListAgents = new System.Windows.Forms.Button();
            this.btnListHouses = new System.Windows.Forms.Button();
            this.btnSearchAgent = new System.Windows.Forms.Button();
            this.btnSearchHouse = new System.Windows.Forms.Button();
            this.txtAgentId = new System.Windows.Forms.TextBox();
            this.txtHouseId = new System.Windows.Forms.TextBox();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(518, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 68;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::prjFinalProjectPartII.Properties.Resources.remaxBaloonMini;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(60, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 72);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnListAgents
            // 
            this.btnListAgents.Location = new System.Drawing.Point(378, 145);
            this.btnListAgents.Name = "btnListAgents";
            this.btnListAgents.Size = new System.Drawing.Size(75, 23);
            this.btnListAgents.TabIndex = 62;
            this.btnListAgents.Text = "List";
            this.btnListAgents.UseVisualStyleBackColor = true;
            this.btnListAgents.Click += new System.EventHandler(this.btnListAgents_Click);
            // 
            // btnListHouses
            // 
            this.btnListHouses.Location = new System.Drawing.Point(378, 110);
            this.btnListHouses.Name = "btnListHouses";
            this.btnListHouses.Size = new System.Drawing.Size(75, 23);
            this.btnListHouses.TabIndex = 61;
            this.btnListHouses.Text = "List";
            this.btnListHouses.UseVisualStyleBackColor = true;
            this.btnListHouses.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearchAgent
            // 
            this.btnSearchAgent.Location = new System.Drawing.Point(378, 210);
            this.btnSearchAgent.Name = "btnSearchAgent";
            this.btnSearchAgent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAgent.TabIndex = 60;
            this.btnSearchAgent.Text = "Search";
            this.btnSearchAgent.UseVisualStyleBackColor = true;
            this.btnSearchAgent.Click += new System.EventHandler(this.btnSearchAgent_Click);
            // 
            // btnSearchHouse
            // 
            this.btnSearchHouse.Location = new System.Drawing.Point(378, 178);
            this.btnSearchHouse.Name = "btnSearchHouse";
            this.btnSearchHouse.Size = new System.Drawing.Size(75, 23);
            this.btnSearchHouse.TabIndex = 59;
            this.btnSearchHouse.Text = "Search";
            this.btnSearchHouse.UseVisualStyleBackColor = true;
            this.btnSearchHouse.Click += new System.EventHandler(this.btnSearchHouse_Click);
            // 
            // txtAgentId
            // 
            this.txtAgentId.Location = new System.Drawing.Point(281, 209);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.Size = new System.Drawing.Size(86, 20);
            this.txtAgentId.TabIndex = 58;
            // 
            // txtHouseId
            // 
            this.txtHouseId.Location = new System.Drawing.Point(281, 181);
            this.txtHouseId.Name = "txtHouseId";
            this.txtHouseId.Size = new System.Drawing.Size(86, 20);
            this.txtHouseId.TabIndex = 54;
            // 
            // gridResult
            // 
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(60, 260);
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(533, 168);
            this.gridResult.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "List Agents :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "List Houses : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Search Agent by ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Search House by ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(248, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "SEARCH VIEW";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListAgents);
            this.Controls.Add(this.btnListHouses);
            this.Controls.Add(this.btnSearchAgent);
            this.Controls.Add(this.btnSearchHouse);
            this.Controls.Add(this.txtAgentId);
            this.Controls.Add(this.txtHouseId);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListAgents;
        private System.Windows.Forms.Button btnListHouses;
        private System.Windows.Forms.Button btnSearchAgent;
        private System.Windows.Forms.Button btnSearchHouse;
        private System.Windows.Forms.TextBox txtAgentId;
        private System.Windows.Forms.TextBox txtHouseId;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}