﻿namespace WindowsFormsApp1.Sales_Status
{
    partial class Sales_StatusABC
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.map2 = new WindowsFormsApp1.Map();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableControl2 = new WindowsFormsApp1.UserForm_list.TableControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.map2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 570);
            this.panel1.TabIndex = 1;
            // 
            // map2
            // 
            this.map2.Location = new System.Drawing.Point(19, 3);
            this.map2.Name = "map2";
            this.map2.Size = new System.Drawing.Size(750, 550);
            this.map2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableControl2);
            this.panel2.Location = new System.Drawing.Point(815, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 570);
            this.panel2.TabIndex = 2;
            // 
            // tableControl2
            // 
            this.tableControl2.Location = new System.Drawing.Point(5, 3);
            this.tableControl2.Name = "tableControl2";
            this.tableControl2.Size = new System.Drawing.Size(410, 500);
            this.tableControl2.TabIndex = 0;
            // 
            // Sales_StatusABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Sales_StatusABC";
            this.Size = new System.Drawing.Size(1260, 570);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Map map1;
        private System.Windows.Forms.Panel panel2;
        private UserForm_list.TableControl tableControl1;
        private Map map2;
        private UserForm_list.TableControl tableControl2;
    }
}
