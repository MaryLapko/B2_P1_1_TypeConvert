using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            decimal photoPriceSecond = 85;

            int birthYear = 2000;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string sex1 = 'M'; //implicit неявное not compiling
            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL
            //bool hasFingerPrints1 = hasFingerPrints; //implicit not compiling
            //bool hasFingerPrints1 = (bool)hasFingerPrints; //EXPLICIT: NOT COMPILING
            bool hasFingerPrints1 = Convert.ToBoolean(hasFingerPrints); //CONVERT: "0"

            //1.3 CHAR to DECIMAL
            decimal place1 = place;  //IMPLICIT: COMPILING
            decimal place2 = (decimal)place;  //EXPLICIT: COMPILING
            decimal place3 = Convert.ToDecimal(place); //CONVERT: "3"

            //1.4 CHAR to INT
            int placeCharToInt = place; //IMPLICIT: COMPILING
            int placeChartoInt2 = (int)place; //EXPLICIT: COMPILING
            int placeChartoInt3 = Convert.ToInt32(place);//CONVERT: "3"

            //2. STRING CONVERSION

            //2.1 STRING to CHAR
            // char nameToString = name; //IMPLICIT: NOT COMPILING
            //char nameToString = (char)name; //EXPLICIT: NOT COMPILING
            char nameToString = Convert.ToChar(name);//CONVERT: "Olga"

            //2.2 STRING to BOOL
            //bool hasPhotoToBool = hasPhoto; //IMPLICIT: NOT COMPILING
            // bool hasPhotoToBool = (bool)hasPhoto; //EXPLICIT: NOT COMPILING
            bool hasPhotoToBool = Convert.ToBoolean(hasPhoto); //CONVERT: "True"


            //2.3 STRING to DECIMAL
            // decimal flatNumberToDecimal = flatNumber; //IMPLICIT: NOT COMPILING
            // decimal flatNumberToDecimal = (decimal)flatNumber; //EXPLICIT: NOT COMPILING
            decimal flatNumberToDecimal = Convert.ToDecimal(flatNumber); //IMPLICIT: NOT COMPILING


            //2.4 STRING to INT
            //int flatNumberToInt = flatNumber; //IMPLICIT: NOT COMPILING
            //int flatNumberToInt = (int)flatNumber; //EXPLICIT: NOT COMPILING
            int flatNuberToInt  = Convert.ToInt32(flatNumber); //CONVERT: "34"

            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR
            //char hasFree2PagesToChar = hasFree2Pages; //IMPLICIT: NOT COMPILING
            //char hasFree2PagesToChar = (char)hasFree2Pages; //EXPLICIT: NOT COMPILING
            char hasFree2PagesToChar = Convert.ToChar(hasFree2Pages); //CONVERT: "false"

            //3.2 BOOL to STRING
            //string hasFree2PagesToString = hasFree2Pages;//IMPLICIT: NOT COMPILING
            //string hasFree2PagesToString = (string)hasFree2Pages;//EXPLICIT: NOT COMPILING
            string hasFree2PagesToString = Convert.ToString(hasFree2Pages);//CONVERT: "false"

            //3.3 BOOL to DECIMAL
            //decimal hasFree2PagesToDecimal = hasFree2Pages;//IMPLICIT: NOT COMPILING
            //decimal hasFree2PagesToDecimal = (decimal)hasFree2Pages;//EXPLICIT: NOT COMPILING
            decimal hasFree2PagesToDecimal = Convert.ToDecimal(hasFree2Pages);//CONVERT: "false"

            //3.4 BOOL to INT
            //int hasFree2PagesToInt = hasFree2Pages;//IMPLICIT: NOT COMPILING
            //int hasFree2PagesToInt = (int)hasFree2Pages;//EXPLICIT: NOT COMPILING
            int hasFree2PagesToInt = Convert.ToInt32(hasFree2Pages);//CONVERT: "false"


            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR
            //char photPriceSecondToChar = photoPriceSecond; //IMPLICIT: NOT COMPILING
            char photoPriceSecondToChar = (char)photoPriceSecond; //EXPLICIT: COMPILING
            char photoPriceSecondToChar2 = Convert.ToChar(photoPriceSecond);//CONVERT: "85"

            //4.2 DECIMAL to BOOL
            //bool photPriceSecondToBool = photoPriceSecond; //IMPLICIT: NOT COMPILING
            //bool photoPriceSecondToBool = (bool)photoPriceSecond; //EXPLICIT: NOT COMPILING
            bool photoPriceSecondToBool = Convert.ToBoolean(photoPriceSecond);//CONVERT: "85"

            //4.3 DECIMAL to STRING
            //string photPriceSecondToString = photoPriceSecond; //IMPLICIT: NOT COMPILING
            //str/ing photoPriceSecondToString = (string)photoPriceSecond; //EXPLICIT: NOT COMPILING
            string photoPriceSecondToString = Convert.ToString(photoPriceSecond);//CONVERT: "85"

            //4.4 DECIMAL to INT
            //int photPriceSecondToInt = photoPriceSecond; //IMPLICIT: NOT COMPILING
            int photoPriceSecondToInt = (int)photoPriceSecond; //EXPLICIT: NOT COMPILING
            int photoPriceSecondToInt2 = Convert.ToInt32(photoPriceSecond);//CONVERT: "85"

            //5. INT CONVERSION         

            //5.1 INT to CHAR
            //char birthYearToChar = birthYear;//IMPLICIT: NOT COMPILING
            char birthYearToChar = (char)birthYear; //EXPLICIT: COMPILING
            char birthYearToChar2 = Convert.ToChar(birthYear); //CONVERT: "2000"

            //5.2 INT to BOOL
            //bool birthYearToBool = birthYear;//IMPLICIT: NOT COMPILING
            //bool birthYearToBool = (bool)birthYear; //EXPLICIT: NOT COMPILING
            bool birthYearToBool = Convert.ToBoolean(birthYear); //CONVERT: "2000"

            //5.3 INT to DECIMAL
            decimal birthYearToDecimal = birthYear;//IMPLICIT: COMPILING
            decimal birthYearToDecimal1 = (decimal)birthYear; //EXPLICIT: COMPILING
            decimal birthYearToDecimal2 = Convert.ToDecimal(birthYear); //CONVERT: "2000"

            //5.4 INT to STRING
            //string birthYearToString = birthYear;//IMPLICIT: NOT COMPILING
            //string birthYearToString = (string)birthYear; //EXPLICIT: NOT COMPILING
            string birthYearToString = Convert.ToString(birthYear); //CONVERT: "2000"
        }
    }
}
