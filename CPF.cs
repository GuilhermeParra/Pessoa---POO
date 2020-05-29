namespace Pessoa___POO
{
    //chamamos a Herança da superclasse "Pessoa"
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        public bool validarCPF(){
            if (cpf != null){
                return true;
            }
            return false;
        }
    }
}