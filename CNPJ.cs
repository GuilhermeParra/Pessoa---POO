namespace Pessoa___POO
{
    public class CNPJ
    {
        public string cnpj;
        public bool validarCNPJ(){
            if(cnpj != null){
                return true;
            }
            return false;
        }
    }
}