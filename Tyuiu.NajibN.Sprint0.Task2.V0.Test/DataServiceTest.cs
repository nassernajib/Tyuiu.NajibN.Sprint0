﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NajibN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NajibN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область Создания Метод Тестирования, Методв Из Библиотеки
            var name = "Нассер";
            var res = DataService.GetMessage(name);

            //Вызываем Класс Assert и Метод AreEqual
            Assert.AreEqual("привет...,Нассер", res);
        }
    }
}
