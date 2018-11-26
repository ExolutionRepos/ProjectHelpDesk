namespace UI.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_TBL_CHAMADOS_DataInicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_CHAMADOS",
                c => new
                    {
                        CodigoChamado = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Observacao = c.String(maxLength: 100, unicode: false),
                        CodigoTipoChamado = c.Int(nullable: false),
                        CodigoProduto = c.Int(nullable: false),
                        CodigoUsuario_Cliente = c.Int(nullable: false),
                        CodigoUsuario_Funcionario = c.Int(nullable: false),
                        CodigoDepartamento = c.Int(),
                        Status = c.Int(nullable: false),
                        Prioridade = c.Int(nullable: false),
                        DataInicio = c.DateTime(),
                        DataFinalizacao = c.DateTime(),
                        Usuarios_CodigoUsuario = c.Int(),
                        Usuarios_CodigoUsuario1 = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoChamado)
                .ForeignKey("dbo.TBL_USUARIOS", t => t.Usuarios_CodigoUsuario)
                .ForeignKey("dbo.TBL_DEPARTAMENTOS", t => t.CodigoDepartamento)
                .ForeignKey("dbo.TBL_USUARIOS", t => t.Usuarios_CodigoUsuario1)
                .ForeignKey("dbo.TBL_USUARIOS", t => t.CodigoUsuario_Cliente)
                .ForeignKey("dbo.TBL_USUARIOS", t => t.CodigoUsuario_Funcionario)
                .ForeignKey("dbo.TBL_PRODUTOS", t => t.CodigoProduto)
                .ForeignKey("dbo.TBL_TIPOCHAMADO", t => t.CodigoTipoChamado)
                .Index(t => t.CodigoTipoChamado)
                .Index(t => t.CodigoProduto)
                .Index(t => t.CodigoUsuario_Cliente)
                .Index(t => t.CodigoUsuario_Funcionario)
                .Index(t => t.CodigoDepartamento)
                .Index(t => t.Usuarios_CodigoUsuario)
                .Index(t => t.Usuarios_CodigoUsuario1);

            CreateTable(
                "dbo.TBL_USUARIOS",
                c => new
                    {
                        CodigoUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(),
                        Email = c.String(maxLength: 100, unicode: false),
                        CPF = c.String(maxLength: 100, unicode: false),
                        Sexo = c.Int(nullable: false),
                        Telefone = c.String(maxLength: 100, unicode: false),
                        Celular = c.String(maxLength: 100, unicode: false),
                        CodigoLogin = c.Int(),
                        CodigoTipoUsuario = c.Int(nullable: false),
                        CodigoDepartamento = c.Int(),
                        Endereco_CodigoEndereco = c.Int(nullable: false),
                        Fonte_Codigo_ConfigFont = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoUsuario)
                .ForeignKey("dbo.TBL_DEPARTAMENTOS", t => t.CodigoDepartamento)
                .ForeignKey("dbo.TBL_ENDERECO", t => t.Endereco_CodigoEndereco)
                .ForeignKey("dbo.TBL_CONFIGURACAOFONTE", t => t.Fonte_Codigo_ConfigFont)
                .ForeignKey("dbo.TBL_LOGINS", t => t.CodigoLogin)
                .ForeignKey("dbo.TBL_TIPOUSUARIO", t => t.CodigoTipoUsuario)
                .Index(t => t.CodigoLogin)
                .Index(t => t.CodigoTipoUsuario)
                .Index(t => t.CodigoDepartamento)
                .Index(t => t.Endereco_CodigoEndereco)
                .Index(t => t.Fonte_Codigo_ConfigFont);
            
            CreateTable(
                "dbo.TBL_DEPARTAMENTOS",
                c => new
                    {
                        CodigoDepartamento = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CodigoDepartamento);
            
            CreateTable(
                "dbo.TBL_ENDERECO",
                c => new
                    {
                        CodigoEndereco = c.Int(nullable: false, identity: true),
                        Rua = c.String(maxLength: 100, unicode: false),
                        Bairro = c.String(maxLength: 100, unicode: false),
                        CEP = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(maxLength: 100, unicode: false),
                        UF = c.String(maxLength: 100, unicode: false),
                        Numero = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoEndereco);
            
            CreateTable(
                "dbo.TBL_CONFIGURACAOFONTE",
                c => new
                    {
                        Codigo_ConfigFont = c.Int(nullable: false, identity: true),
                        Fonte = c.String(maxLength: 100, unicode: false),
                        Tamanho = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo_ConfigFont);
            
            CreateTable(
                "dbo.TBL_LOGINS",
                c => new
                    {
                        CodigoLogin = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 100, unicode: false),
                        Senha = c.String(maxLength: 100, unicode: false),
                        SenhaAntiga = c.String(maxLength: 100, unicode: false),
                        Status = c.Int(nullable: false),
                        CodigoPerfil = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoLogin)
                .ForeignKey("dbo.TBL_PERFIS", t => t.CodigoPerfil)
                .Index(t => t.CodigoPerfil);
            
            CreateTable(
                "dbo.TBL_PERFIS",
                c => new
                    {
                        CodigoPerfil = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CodigoPerfil);
            
            CreateTable(
                "dbo.TBL_TIPOUSUARIO",
                c => new
                    {
                        CodigoTipoUsuario = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CodigoTipoUsuario);
            
            CreateTable(
                "dbo.TBL_PRODUTOS",
                c => new
                    {
                        CodigoProduto = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        DataCompra = c.DateTime(),
                        DataFabricacao = c.DateTime(),
                        Marca = c.Int(nullable: false),
                        Modelo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoProduto);
            
            CreateTable(
                "dbo.TBL_TIPOCHAMADO",
                c => new
                    {
                        CodigoTipoChamado = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        SLA = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CodigoTipoChamado);
            
            CreateTable(
                "dbo.TBL_BASECONHECIMENTO",
                c => new
                    {
                        CodigoBaseConhecimento = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        PalavraChave = c.String(maxLength: 100, unicode: false),
                        TipoChamado_CodigoTipoChamado = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoBaseConhecimento)
                .ForeignKey("dbo.TBL_TIPOCHAMADO", t => t.TipoChamado_CodigoTipoChamado)
                .Index(t => t.TipoChamado_CodigoTipoChamado);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_CHAMADOS", "CodigoTipoChamado", "dbo.TBL_TIPOCHAMADO");
            DropForeignKey("dbo.TBL_BASECONHECIMENTO", "TipoChamado_CodigoTipoChamado", "dbo.TBL_TIPOCHAMADO");
            DropForeignKey("dbo.TBL_CHAMADOS", "CodigoProduto", "dbo.TBL_PRODUTOS");
            DropForeignKey("dbo.TBL_CHAMADOS", "CodigoUsuario_Funcionario", "dbo.TBL_USUARIOS");
            DropForeignKey("dbo.TBL_CHAMADOS", "CodigoUsuario_Cliente", "dbo.TBL_USUARIOS");
            DropForeignKey("dbo.TBL_USUARIOS", "CodigoTipoUsuario", "dbo.TBL_TIPOUSUARIO");
            DropForeignKey("dbo.TBL_USUARIOS", "CodigoLogin", "dbo.TBL_LOGINS");
            DropForeignKey("dbo.TBL_LOGINS", "CodigoPerfil", "dbo.TBL_PERFIS");
            DropForeignKey("dbo.TBL_CHAMADOS", "Usuarios_CodigoUsuario1", "dbo.TBL_USUARIOS");
            DropForeignKey("dbo.TBL_USUARIOS", "Fonte_Codigo_ConfigFont", "dbo.TBL_CONFIGURACAOFONTE");
            DropForeignKey("dbo.TBL_USUARIOS", "Endereco_CodigoEndereco", "dbo.TBL_ENDERECO");
            DropForeignKey("dbo.TBL_USUARIOS", "CodigoDepartamento", "dbo.TBL_DEPARTAMENTOS");
            DropForeignKey("dbo.TBL_CHAMADOS", "CodigoDepartamento", "dbo.TBL_DEPARTAMENTOS");
            DropForeignKey("dbo.TBL_CHAMADOS", "Usuarios_CodigoUsuario", "dbo.TBL_USUARIOS");
            DropIndex("dbo.TBL_BASECONHECIMENTO", new[] { "TipoChamado_CodigoTipoChamado" });
            DropIndex("dbo.TBL_LOGINS", new[] { "CodigoPerfil" });
            DropIndex("dbo.TBL_USUARIOS", new[] { "Fonte_Codigo_ConfigFont" });
            DropIndex("dbo.TBL_USUARIOS", new[] { "Endereco_CodigoEndereco" });
            DropIndex("dbo.TBL_USUARIOS", new[] { "CodigoDepartamento" });
            DropIndex("dbo.TBL_USUARIOS", new[] { "CodigoTipoUsuario" });
            DropIndex("dbo.TBL_USUARIOS", new[] { "CodigoLogin" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "Usuarios_CodigoUsuario1" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "Usuarios_CodigoUsuario" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "CodigoDepartamento" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "CodigoUsuario_Funcionario" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "CodigoUsuario_Cliente" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "CodigoProduto" });
            DropIndex("dbo.TBL_CHAMADOS", new[] { "CodigoTipoChamado" });
            DropTable("dbo.TBL_BASECONHECIMENTO");
            DropTable("dbo.TBL_TIPOCHAMADO");
            DropTable("dbo.TBL_PRODUTOS");
            DropTable("dbo.TBL_TIPOUSUARIO");
            DropTable("dbo.TBL_PERFIS");
            DropTable("dbo.TBL_LOGINS");
            DropTable("dbo.TBL_CONFIGURACAOFONTE");
            DropTable("dbo.TBL_ENDERECO");
            DropTable("dbo.TBL_DEPARTAMENTOS");
            DropTable("dbo.TBL_USUARIOS");
            DropTable("dbo.TBL_CHAMADOS");
        }
    }
}
