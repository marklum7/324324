using ConsoleApp2;
using System.Xml.Linq;

Cat  cat = new Cat{pol="ломинат", name = "керыч", color = "black"};

Dog dog = new Dog { pol = "паркет", name = "велера", poroda = "баландино" };

Pet dog2 = (Pet)dog;

object cat2 = cat as Object;
Pet cat3 = (Pet)cat2;
