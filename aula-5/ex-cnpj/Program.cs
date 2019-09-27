using System;

namespace ex_cnpj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIgite o cnpj: ");
            string cnpj=Console.ReadLine();
            Console.WriteLine(ValidaCnpj(cnpj));
        }
        static bool ValidaCnpj(string cnpjUsuario){
            bool resultado=false;
            int[] v1={5,4,3,2,9,8,7,6,5,4,3,2};
            int[] v2={6,5,4,3,2,9,8,7,6,5,4,3,2};
            string cnpjcalculo="";
            int calculo=0;
            int resto=0;
            string digito_v1="";
            string digito_v2="";
            cnpjUsuario=cnpjUsuario.Replace("/","");
            cnpjUsuario=cnpjUsuario.Replace("-","");
            cnpjUsuario=cnpjUsuario.Replace(".","");
            cnpjUsuario=cnpjUsuario.Replace(" ","");

            cnpjcalculo=cnpjUsuario.Substring(0,12);
            for(int i=0;i<=11;i++){
                calculo+=int.Parse(cnpjcalculo[i].ToString())*v1[i];
            }
            resto=calculo%11;
            calculo=11-resto;
            if(resto<2){
                digito_v1="0";
            }
            else{
                digito_v1=calculo.ToString();
            }
            if(digito_v1==cnpjUsuario[12].ToString()){
                resultado=true;
            }
            calculo=0;
            resto=0;
            cnpjcalculo+=digito_v1;
            for(int i=0;i<=12;i++){
                calculo+=int.Parse(cnpjcalculo[i].ToString())*v2[i];
            }
                resto=calculo%11;
                calculo=11-resto;
                if(resto<2){
                    digito_v2="0";
                }
                else{
                    digito_v2=(calculo).ToString();
                }
                if(digito_v2==cnpjUsuario[13].ToString()){
                resultado=true;
                }else{
                    resultado=false;
                }


            return resultado;
        }

    }
}
