using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = "";


            int i = 1; string enume;
            for (i = 1; i <= 20; i++)
            {
   
                if (i < 10)
                {
                   enume = "0" + i;
                }
                else {
                    enume = Convert.ToString(i);
                }
                cadena += " <font color='red'> ";
                cadena += "<font style='background-color:#008ec1; font-size: 11pt; font-family: cursive; color: #FAFAFA'><b>" + enume + "</b></font>" + "<br>El sistema reporta infactibilidad para el cajero <strong> <font color='black'>0000000004 </font></strong>. El monto especificado como inicial (Otro Monto) excede el encaje máximo del mismo. <hr size='3px' color='#008ec1'  width='95%'/> ";
                cadena += "El sistema reporta infactibilidad para el cajero <strong> <font color='black'>0000000004 </font></strong>. El monto especificado como inicial (Otro Monto) excede el encaje máximo del mismo. <hr size='3px' color='#008ec1'  width='95%'/>";
                cadena += "El sistema reporta infactibilidad para el cajero <strong> <font color='black'>0000000004 </font></strong>. El monto especificado como inicial (Otro Monto) excede el encaje máximo del mismo. <hr size='3px' color='#008ec1'  width='95%'/>";
                cadena += "El sistema reporta infactibilidad para el cajero <strong> <font color='black'>0000000004 </font></strong>. El monto especificado como inicial (Otro Monto) excede el encaje máximo del mismo. <hr size='3px' color='#008ec1'  width='95%'/>";
                cadena += "El sistema reporta infactibilidad para el cajero <strong> <font color='black'>0000000004 </font></strong>. El monto especificado como inicial (Otro Monto) excede el encaje máximo del mismo. <hr size='3px' color='#008ec1'  width='95%'/>";
                cadena += "El sistema reporta infactibilidad para el cajero <strong> <font color='black'>0000000004 </font></strong>. El monto especificado como inicial (Otro Monto) excede el encaje máximo del mismo.  <hr size='3px' color='#008ec1'  width='95%'/>";
                cadena += "Se ha Excedido el tiempo. <hr size='3px' color='#008ec1'  width='95%'/>";
                cadena += "</font>  ";

                cadena += "<table>";
                cadena += "<tr>";
                cadena += "<td style='padding: 4px; '>  <b>REPORTECLIENTE:  </b></td>";
                cadena += "<td style='padding: 3px;'> Banco Provincial </td>";
                cadena += "</tr>";
                cadena += "<tr>";
                cadena += "<td style='padding: 4px; '><b> ATM:  </b></td>";
                cadena += "<td style='padding: 3px; color:#008ec1'><b> 0000000903  </b></td>";
                cadena += "</tr>";
                cadena += "<tr>";
                cadena += "<td style='padding: 4px; '>  <b>FECHA PROGRAMACION:  </b></td>";
                cadena += "<td style='padding: 3px; color:red''> <b> 22/11/2016 08:48:27 a.m </b></td>";
                cadena += "</tr>";
                cadena += "<tr>";
                cadena += "<td style='padding: 4px; '>  <b>INICIO DE PROGRAMACION:  </b></td>";
                cadena += "<td style='padding: 3px; '> 23/11/2016 </td>";
                cadena += "</tr>";
                cadena += "<tr>";
                cadena += "<td style='padding: 4px; '>  <b>FIN DE PROGRAMACION:  </b></td>";
                cadena += "<td style='padding: 3px; '> 25/11/2016 </td>";
                cadena += "</tr>";
                cadena += "<tr>";
                cadena += "<td style='padding: 4px; '> <b>NOTA:  </b></td>";
                cadena += "<td style='padding: 3px; '> ESTE CAJERO FUE MIGRADO (BOLIVARES FUERTES) </td>";
                cadena += "</tr>";
                cadena += "</table> <hr size='3px' color='#008ec1'  width='95%'/>";

                cadena += "<table style='border-width: 1.5px; border-color:#008ec1; border-style:solid;'>";
                cadena += "     <tr style=' border-width: 1.5px; border-color:#008ec1; border-style:solid; background-color:#008ec1; color:white; text-align: center;'> ";
                cadena += "         <th style='padding: 4px; border-width: 1.5px; border-color:#008ec1; border-style:solid; ' > FECHA</th> ";
                cadena += "         <th style='padding: 4px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '> MONTO</th> ";
                cadena += "         <th style='padding: 4px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '> SALDO PREVISTO</th>";
                cadena += "     </tr>";
                cadena += "    <tr style=' padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; text-align: left;'> ";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid;'>23/11/2016</td>";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '>361.000,00</td>";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '>317.678</td>";
                cadena += "    </tr>";
                cadena += "    <tr style=' padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; text-align: left;'> ";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid;'>23/11/2016</td>";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '>361</td>";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '>317.678,00</td>";
                cadena += "    </tr>";
                cadena += "    <tr style=' padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; text-align: left;'> ";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid;'>23/11/2016</td>";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '>361.000,00</td>";
                cadena += "         <td style='padding: 8px; border-width: 1.5px; border-color:#008ec1; border-style:solid; '>317.678</td>";
                cadena += "    </tr>";
                cadena += "</table> <hr size='3px' color='#008ec1'  width='95%'/>";

            }

            Label1.Text = cadena;

            if (i > 10)
            {
                verTodo.Visible = true;
            }

            

        }

        protected void cp_Click(object sender, EventArgs e)
        {

        }
    }
}