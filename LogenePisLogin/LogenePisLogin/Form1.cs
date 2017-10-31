﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Windows.Forms;
using dbbase;

namespace LogenePisLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var r = (new LoginDialog()).ShowDialog();
        }



        public class Yh
        {
            [DisplayName("编号")]
            public string Id { get; set; }
            [DisplayName("登录名")]
            public string Yhm { get; set; }
            [DisplayName("密码")]
            public string Yhmm { get; set; }
            [DisplayName("用户名称")]
            public string Yhmc { get; set; }
            [DisplayName("拼音码")]
            public string PYM { get; set; }


            public static Yh FromRow(DataRow dr)
            {
                Yh yh = new Yh();
                yh.Yhm = dr["f_yhm"].ToString();
                yh.Yhmc = dr["f_yhmc"].ToString();
                yh.Yhmm = dr["f_yhmm"].ToString();
                yh.PYM = GetSpellCode(yh.Yhmc);
                yh.Id = dr["F_ID"].ToString();
                return yh;
            }


            #region Overrides of Object

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            /// <returns>
            /// A string that represents the current object.
            /// </returns>
            public override string ToString()
            {
                return this.Yhmc + "  |  " + Yhm;
            }

            #endregion

            #region 获取拼音码

            /// <summary>
            /// 在指定的字符串列表CnStr中检索符合拼音索引字符串
            /// </summary>
            /// <param name="CnStr">汉字字符串</param>
            /// <returns>相对应的汉语拼音首字母串</returns>
            public static string GetSpellCode(string CnStr)
            {
                string strTemp = "";

                int iLen = CnStr.Length;

                int i = 0;

                for (i = 0; i <= iLen - 1; i++)
                {
                    strTemp += GetCharSpellCode(CnStr.Substring(i, 1));
                }

                return strTemp;
            }

            /// <summary>
            /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母
            /// </summary>
            /// <param name="CnChar">单个汉字</param>
            /// <returns>单个大写字母</returns>
            private static string GetCharSpellCode(string CnChar)
            {
                long iCnChar;

                byte[] ZW = Encoding.Default.GetBytes(CnChar);

                //如果是字母，则直接返回

                if (ZW.Length == 1)
                {
                    return CnChar.ToUpper();
                }

                else
                {
                    // get the array of byte from the single char

                    int i1 = (short)(ZW[0]);

                    int i2 = (short)(ZW[1]);

                    iCnChar = i1 * 256 + i2;
                }

                // iCnChar match the constant
                if (CnChar == "血") return "X";
                else if ((iCnChar >= 45217) && (iCnChar <= 45252))
                {
                    return "A";
                }

                else if ((iCnChar >= 45253) && (iCnChar <= 45760))
                {
                    return "B";
                }
                else if ((iCnChar >= 45761) && (iCnChar <= 46317))
                {
                    return "C";
                }
                else if ((iCnChar >= 46318) && (iCnChar <= 46825))
                {
                    return "D";
                }
                else if ((iCnChar >= 46826) && (iCnChar <= 47009))
                {
                    return "E";
                }
                else if ((iCnChar >= 47010) && (iCnChar <= 47296))
                {
                    return "F";
                }
                else if ((iCnChar >= 47297) && (iCnChar <= 47613))
                {
                    return "G";
                }
                else if ((iCnChar >= 47614) && (iCnChar <= 48118))
                {
                    return "H";
                }
                else if ((iCnChar >= 48119) && (iCnChar <= 49061))
                {
                    return "J";
                }
                else if ((iCnChar >= 49062) && (iCnChar <= 49323))
                {
                    return "K";
                }
                else if ((iCnChar >= 49324) && (iCnChar <= 49895))
                {
                    return "L";
                }
                else if ((iCnChar >= 49896) && (iCnChar <= 50370))
                {
                    return "M";
                }
                else if ((iCnChar >= 50371) && (iCnChar <= 50613))
                {
                    return "N";
                }
                else if ((iCnChar >= 50614) && (iCnChar <= 50621))
                {
                    return "O";
                }
                else if ((iCnChar >= 50622) && (iCnChar <= 50905))
                {
                    return "P";
                }
                else if ((iCnChar >= 50906) && (iCnChar <= 51386))
                {
                    return "Q";
                }
                else if ((iCnChar >= 51387) && (iCnChar <= 51445))
                {
                    return "R";
                }
                else if ((iCnChar >= 51446) && (iCnChar <= 52217))
                {
                    return "S";
                }
                else if ((iCnChar >= 52218) && (iCnChar <= 52697))
                {
                    return "T";
                }
                else if ((iCnChar >= 52698) && (iCnChar <= 52979))
                {
                    return "W";
                }
                else if ((iCnChar >= 52980) && (iCnChar <= 53640))
                {
                    return "X";
                }
                else if ((iCnChar >= 53689) && (iCnChar <= 54480))
                {
                    return "Y";
                }
                else if ((iCnChar >= 54481) && (iCnChar <= 55289))
                {
                    return "Z";
                }
                else

                    return ("?");
            }

            #endregion
        }
    }
}