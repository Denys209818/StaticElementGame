using System;
using System.Collections.Generic;
using System.Text;

namespace convincingStatic.Services
{
    public static class BorderService
    {
        /// <summary>
        ///     Метод перевіряє чи можна елемент переносити у ліво
        /// </summary>
        /// <param name="px">Приймає актуальну координату X</param>
        /// <returns>Повертає значення true якщо можна посунути елемент у ліво</returns>
        public static bool LeftBorder(int px) 
        {
            if (px > 0) 
            {
                return true;
            }
            return false;
        }
        /// <summary>
        ///     Метод перевіряє чи можна елемент переносити у право
        /// </summary>
        /// <param name="px">Приймає актуальну координату X</param>
        /// <param name="maxSize">Приймає актуальну ширину форми</param>
        /// <returns>Повертає значення true якщо можна посунути елемент у право</returns>
        public static bool RightBorder(int px, int maxSize)
        {
            if (px+10 < maxSize)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        ///     Метод перевіряє чи можна елемент переносити вгору
        /// </summary>
        /// <param name="py">Приймає актуальну координату Y</param>
        /// <returns>Повертає значення true якщо можна посунути елемент вгору</returns>
        public static bool UpBorder(int py)
        {
            if (py > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        ///     Метод перевіряє чи можна елемент переносити вниз
        /// </summary>
        /// <param name="px">Приймає актуальну координату Y</param>
        /// <param name="maxHeigth">Приймає актуальну висоту</param>
        /// <returns>Повертає значення true якщо можна посунути елемент вниз</returns>
        public static bool DownBorder(int py, int maxHeigth)
        {
            if (py < maxHeigth - 35)
            {
                return true;
            }
            return false;
        }
    }
}
