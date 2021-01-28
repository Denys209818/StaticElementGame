using System;
using System.Collections.Generic;
using System.Text;

namespace convincingStatic.Services
{
    public static class PathService
    {
        /// <summary>
        ///     В залежності від параметрів переміщує елемент у право
        /// </summary>
        /// <param name="mx">Координа X - курсор</param>
        /// <param name="my">Координа y - курсор</param>
        /// <param name="px">Координа X - фотографії</param>
        /// <param name="py">Координа y - фотографії</param>
        /// <returns>Повертає true якщо можна перемістити елемент у право</returns>
        public static bool ToRight(int mx, int my, int px, int py) 
        {
            if (mx + 5 >= px
                && mx + 5 <= px + 85
                && my >= py
                && my <= py+85
                )
            {
                return true;
            }

            return false;
        }
        /// <summary>
        ///     В залежності від параметрів переміщує елемент у ліво
        /// </summary>
        /// <param name="mx">Координа X - курсор</param>
        /// <param name="my">Координа y - курсор</param>
        /// <param name="px">Координа X - фотографії</param>
        /// <param name="py">Координа y - фотографії</param>
        /// <returns>Повертає true якщо можна перемістити елемент у ліво</returns>
        public static bool ToLeft(int mx, int my, int px, int py)
        {
            if (mx + 5 >= px + 85
                && mx + 5 <= px + 95
                && my >= py
                && my <= py + 85
                )
            {
                return true;
            }

            return false;
        }
        /// <summary>
        ///     В залежності від параметрів переміщує елемент вгору
        /// </summary>
        /// <param name="mx">Координа X - курсор</param>
        /// <param name="my">Координа y - курсор</param>
        /// <param name="px">Координа X - фотографії</param>
        /// <param name="py">Координа y - фотографії</param>
        /// <returns>Повертає true якщо можна перемістити елемент вгору</returns>
        public static bool ToUp(int mx, int my, int px, int py)
        {
            if (my >= py + 85
                && my <= py + 90
                && mx >= px
                && mx <= px + 85
                )
            {
                return true;
            }

            return false;
        }
        /// <summary>
        ///     В залежності від параметрів переміщує елемент вниз
        /// </summary>
        /// <param name="mx">Координа X - курсор</param>
        /// <param name="my">Координа y - курсор</param>
        /// <param name="px">Координа X - фотографії</param>
        /// <param name="py">Координа y - фотографії</param>
        /// <returns>Повертає true якщо можна перемістити елемент вниз</returns>
        public static bool ToBottom(int mx, int my, int px, int py)
        {
            if (my + 5 >= py
                && my + 5 <= py + 5
                && mx >= px
                && mx <= px + 85
                )
            {
                return true;
            }

            return false;
        }
        /// <summary>
        ///     В залежності від параметрів повертає чи знаходиться курсор на елементі чи ні
        /// </summary>
        /// <param name="mx">Координа X - курсор</param>
        /// <param name="my">Координа y - курсор</param>
        /// <param name="px">Координа X - фотографії</param>
        /// <param name="py">Координа y - фотографії</param>
        /// <returns>Повертає true якщо курсор знаходиться на елементі</returns>
        public static bool IsCoords(int mx, int my, int px, int py) 
        {
            if (mx >= px+5 && mx <= px + 80 && my >= py+5 && my <= py + 80) 
            {
                return true;
            }
            return false;
        }
    }
}
