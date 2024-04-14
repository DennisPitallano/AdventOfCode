namespace _2015.Day._2
{
    public static class Calculate
    {

        /// <summary>
        /// Calculates the total amount of wrapping paper needed for the given presents.
        /// </summary>
        /// <param name="presents">The presents to calculate the total wrapping paper needed for.</param>
        /// <returns>The total amount of wrapping paper needed for the given presents.</returns>
        public static int WrappingPaper(string[] presents)
        {
            var total = 0;
            foreach (var present in presents)
            {
                var dimensions = present.Split('x');
                var l = int.Parse(dimensions[0]);
                var w = int.Parse(dimensions[1]);
                var h = int.Parse(dimensions[2]);

                var surfaceArea = 2 * (l * w + w * h + h * l) + Math.Min(Math.Min(l * w, w * h), h * l);

                total += surfaceArea;
            }

            return total;
        }


        /// <summary>
        /// Calculates the total amount of ribbon needed for the given presents.
        /// </summary>
        /// <param name="presents">The presents to calculate the total ribbon needed for.</param>
        /// <returns>The total amount of ribbon needed for the given presents.</returns>
        public static int Ribbon(string[] presents)
        {
            var totalRibbonFeet = 0;

            foreach (var dimensions in presents)
            {
                var sides = dimensions.Split('x');
                var length = int.Parse(sides[0]);
                var width = int.Parse(sides[1]);
                var height = int.Parse(sides[2]);

                // Calculate the smallest perimeter
                var smallestPerimeter = 2 * (length + width + height - Math.Max(Math.Max(length, width), height));

                // Calculate the ribbon required for the bow
                var bowRibbon = length * width * height;

                // Total ribbon required for this present
                var totalRibbon = smallestPerimeter + bowRibbon;

                // Add to the total feet of ribbon
                totalRibbonFeet += totalRibbon;
            }

            return totalRibbonFeet;
        }

    }
}
