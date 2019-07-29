using System.Collections.Generic;
using System.ComponentModel;

namespace Request_System
{
    public enum UserIsactive : int
    {
        [Description("")]
        _ = 0,
        [Description("Inativo")]
        Inativo = 1,
        [Description("Ativo")]
        Ativo = 2
    };

    public enum UserType : int
    {
        [Description("")]
        _ = 0,
        [Description("Administrador")]
        Administrador = 1,
        [Description("Estoquista")]
        Estoquista = 2,
        [Description("Usuário")]
        Usuario = 3
    };
    public enum UserIdioma : int
    { 
        [Description("Portugues")]
        Portugues = 1,
        [Description("Ingles")]
        Ingles = 2,
        [Description("Espanhol")]
        Espanhol = 3
    };
    public enum ProductIsActive : int
    {
        [Description("")]
        _ = 0,
        [Description("Inativo")]
        Inativo = 1,
        [Description("Ativo")]
        Ativo = 2
    };
    public enum SolicitationStatus : int
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Aprovado")]
        Aprovado = 2,
        [Description("Entregue")]
        Entregue = 3,
        [Description("Rejeitado")]
        Rejeitado = 4
    }
}




