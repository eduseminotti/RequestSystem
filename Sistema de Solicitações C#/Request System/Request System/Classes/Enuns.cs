﻿using System.ComponentModel;

namespace Request_System
{
    public class Enuns
    {

    }
    public enum UserIsactive
    {
        [Description("")]
        Empty = 0,
        [Description("Inativo")]
        Inativo = 1,
        [Description("Ativo")]
        Ativo = 2
    };

    public enum UserType
    {
        [Description("")]
        Empty = 0,
        [Description("Administrador")]
        Administrador = 1,
        [Description("Estoquista")]
        Estoquista = 2,
        [Description("Usuário")]
        Usuario = 3
    };
    public enum UserIdioma
    {
        [Description("")]
        Empty = 0,
        [Description("Portugues")]
        Portugues = 1,
        [Description("Ingles")]
        Ingles = 2,
        [Description("Espanhol")]
        Espanhol = 3
    };
    public enum ProductIsActive
    {
        [Description("")]
        Empty = 0,
        [Description("Inativo")]
        Inativo = 1,
        [Description("Ativo")]
        Ativo = 2
    };
    public enum SolicitationStatus
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




