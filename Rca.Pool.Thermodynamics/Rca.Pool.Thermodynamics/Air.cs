using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.Pool.Thermodynamics
{
    public class Air
    {
        /// <summary>
        /// Universelle Gaskonstante [J/kmol*K]
        /// </summary>
        const double R = 8314.473915;

        /// <summary>
        /// Molekulargewicht des Wasserdampfes [kg/mol]
        /// </summary>
        const double M_W = 18.016;

        public double ParameterA { get; set; }
        public double ParameterB { get; set; }
        public bool ParamaterAutoSelect { get; set; }

        public Air(double a, double b)
        {
            ParamaterAutoSelect = false;
            ParameterA = a;
            ParameterB = b;
        }

        public Air()
        {
            ParamaterAutoSelect = true;
        }

        /// <summary>
        /// Berechnung des Taupunktes
        /// </summary>
        /// <returns>Taupunkt [°C]</returns>
        public double CalcDewPoint(double temperature, double humidityRel)
        {
            SetParameter(temperature);

            var v = Math.Log10(CalcVaporPressure(temperature, humidityRel) / 6.1078);
            return ParameterB * v / (ParameterA - v);
        }

        /// <summary>
        /// Berechnung des Sättigungsdampfdruckes
        /// </summary>
        /// <returns>Sättigungsdampfdruck [hPa]</returns>
        public double CalcSaturationVaporPressure(double temperature)
        {
            SetParameter(temperature);

            return 6.1078 * Math.Pow(10, (ParameterA * temperature) / (ParameterB + temperature));
        }

        /// <summary>
        /// Berechnung des Dampfdruckes
        /// </summary>
        /// <returns>Dampfdruck [hPa]</returns>
        public double CalcVaporPressure(double temperature, double humidityRel)
        {
            SetParameter(temperature);

            return humidityRel / 100 * CalcSaturationVaporPressure(temperature);
        }

        /// <summary>
        /// Berechnung der relativen Luftfeuchte
        /// </summary>
        /// <returns>rel. Luftfeuchte [%]</returns>
        public double CalcHumidityRel(double temperature, double drewPoint)
        {
            SetParameter(temperature);

            return 100 * CalcSaturationVaporPressure(drewPoint) / CalcSaturationVaporPressure(temperature);
        }

        /// <summary>
        /// Berechnung der absoluten Luftfeuchte
        /// </summary>
        /// <returns>abs. Luftfeuchte [g/m^3]</returns>
        public double CalcHumidityAbsByDrewPoint(double temperature, double drewPoint)
        {
            SetParameter(temperature);

            return Math.Pow(10, 5) * M_W / R * CalcSaturationVaporPressure(drewPoint) / CalcKelvinTemperature(temperature);
        }

        /// <summary>
        /// Berechnung der absoluten Luftfeuchte
        /// </summary>
        /// <returns>abs. Luftfeuchte [g/m^3]</returns>
        public double CalcHumidityAbsByHumidity(double temperature, double humidityRel)
        {
            SetParameter(temperature);

            return Math.Pow(10, 5) * M_W / R * CalcVaporPressure(temperature, humidityRel) / CalcKelvinTemperature(temperature);
        }

        public double CalcHumidityRelByHumidity(double temperature, double humidityAbs)
        {
            return humidityAbs * CalcKelvinTemperature(temperature) / (13.2471 * Math.Pow(Math.E, 17.67 * temperature / (temperature + 243.5)));
        }

        /// <summary>
        /// Berechnung der Temperatur in Kelvin
        /// </summary>
        /// <param name="temperature">Temperatur [°C]</param>
        /// <returns>Temperatur [K]</returns>
        private double CalcKelvinTemperature(double temperature)
        {
            SetParameter(temperature);

            return temperature + 273.15;
        }

        private void SetParameter(double temperature)
        {
            if (ParamaterAutoSelect)
            {
                if (temperature >= 0)
                {
                    ParameterA = 7.5;
                    ParameterB = 237.3;
                }
                else
                {
                    ParameterA = 7.6;
                    ParameterB = 240.7;
                }
            }
        }
    }
}
