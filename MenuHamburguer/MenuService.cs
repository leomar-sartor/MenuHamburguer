using System.Collections.Generic;

namespace MenuHamburguer
{
    public class MenuService
    {
        public List<Menu> GetMenu()
        {
            var menus = new List<Menu>();

            var menuOne = new Menu()
            {
                Nome = "Dashboard",
                Descricao = "Painel principal do sistema",
                Area = "Administrador",
                Controller = "dashboard",
                Action = "Index"
            };

            var menuTwo = new Menu()
            {
                Nome = "Usuarios",
                Descricao = "Painel principal do sistema",
                Area = "",
                Controller = "",
                Action = "",
                Itens = new List<Menu>()
                {
                    new Menu()
                    {
                        Nome = "Usuario",
                        Descricao = "Cadastro de Usuarios",
                        Area = "Usuario",
                        Controller = "User",
                        Action = "Index"
                    },
                    new Menu()
                    {
                        Nome = "Funções",
                        Descricao = "Roles de Usuarios",
                        Area = "Usuario",
                        Controller = "Roles",
                        Action = "Index"
                    },
                    new Menu()
                    {
                        Nome = "Declarações",
                        Descricao = "Claims de Usuarios",
                        Area = "Usuario",
                        Controller = "Claims",
                        Action = "Index"
                    }
                }
            };

            menus.Add(menuOne);
            menus.Add(menuTwo);

            return menus;
        }
    }

    public class Menu
    {
        public Menu()
        {
            Itens = new List<Menu>();
        }

        public string Icone { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public List<Menu> Itens { get; set; }
    }
}

