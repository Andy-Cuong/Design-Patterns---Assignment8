using Design_Patterns___Assignment8.Menus;
using Design_Patterns___Assignment8.Waitresses;

Waitress decoupledWaitress = new Waitress(new PancakeMenu(), new DinerMenu());
decoupledWaitress.printMenu();
