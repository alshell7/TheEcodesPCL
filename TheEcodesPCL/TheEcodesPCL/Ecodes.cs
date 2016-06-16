using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheEcodes;

namespace TheEcodes
{
    /// <summary>
    /// A class to get all the valid information of a particular E code.
    /// </summary>
    /// <remarks></remarks>
    public sealed class EcodeInformation
    {

        private string _EquivalentName;
        private string _AbstractInformation;
        private Integrity _CodeIntegrity;
        private string _AdvertName;
        /// <summary>
        /// Gets the qualified name of the E-code or its associated information.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string EquivalentName
        {
            get { return _EquivalentName; }
        }
        /// <summary>
        /// Gets the brief information of the E-code. Basically in terms of integrity.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string AbstractInformation
        {
            get { return _AbstractInformation; }
        }
        /// <summary>
        /// Returns the level of E-code, how accepted it is for consumption as an ingredient.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Integrity CodeIntegrity
        {
            get { return _CodeIntegrity; }
        }
        /// <summary>
        /// Returns the name of E-code that is actually presented on any food item.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string AdvertName
        {
            get { return _AdvertName; }
        }


        /// <summary>
        /// Instantiates the class and gets all the required information of the E-code.
        /// </summary>
        /// <param name="EcodeNumber">E-code whose information to be retrieved.</param>
        /// <remarks></remarks>
        public EcodeInformation(Ecode EcodeNumber)
        {

            /*try
            {*/
                string adtN = Enum.GetName(typeof(Ecode), EcodeNumber);
                _AdvertName = adtN.Insert(1, "-");

                switch (EcodeNumber)
                {

                    case Ecode.E100:
                        _AbstractInformation = "Powder or granular. Suspicion if used as liquid, the solvents has to be Lawful. Unlawful if hidden ingredient is pork fat based emulsifier in dry mix.";
                        _EquivalentName = "Curcumin/Turmeric [As COLOR]";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E101:
                        _AbstractInformation = "Suspicion  (Unlawful if from pork liver & Kidney, Lawful if 100% plant material .";
                        _EquivalentName = "Riboflavin (Vitamin B2) [As COLOR]";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E102:
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful";
                        _EquivalentName = "Tartrazine [As COLOR]";


                        _CodeIntegrity = Integrity.Suspect; break;

                    case Ecode.E104:
                        _EquivalentName = "Quinoline Yellow [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent other than water has to be Lawful.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E110:
                        _EquivalentName = "Sunset Yellow FCF / Orange Yellow S [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E120:
                        _EquivalentName = "Cochineal / Carminic Acid [As COLOR]";
                        _AbstractInformation = "Unlawful .";
                        _CodeIntegrity = Integrity.Unlawful; break;
                    case Ecode.E122:
                        _EquivalentName = "Carmoisine / Azorubine [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E123:
                        _EquivalentName = "Amaranth [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E124:
                        _EquivalentName = "Ponceau 4R / Cochineal Red A [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";
                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E127:
                        _EquivalentName = "Erythrosine BS [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E131:
                        _EquivalentName = "Patent Blue V [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E132:
                        _EquivalentName = "Indigo Carmine / Idigotine [As COLOR]";
                        _AbstractInformation = "Lawful if use as is as a 100% synthetic color  but if pork glycerin is added as a solvent then it is Unlawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E140:
                        _EquivalentName = "Chlorophyll [As COLOR] ";
                        _AbstractInformation = "Lawful if use 100% powder or Lawful if water or vegetable oil was used as a solvent .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E141:
                        _EquivalentName = "Copper Complex of Chlorophyll [As COLOR] ";
                        _AbstractInformation = "Lawful if use 100% powder or Lawful if water or vegetable oil was used as a solvent .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E142:
                        _EquivalentName = "Green S / Acid Brilliant Green BS [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E150a_d:
                        _EquivalentName = "Caramel Color/with chemicals [As COLOR] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E151:
                        _EquivalentName = "Black PN / Brilliant Black BN [As COLOR] ";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E153:
                        _EquivalentName = "Carbon Black / Vegetable Carbon (Charcoal) [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E160a:
                        _EquivalentName = "Alpha, Beta, Gamma [As COLOR- Carotene]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E160b:
                        _EquivalentName = "Annatto, Bixin, Norbixin [As COLOR- Carotene] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E160c:
                        _EquivalentName = "Capsanthin / Capsorbin [As COLOR- Carotene]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E160d:
                        _EquivalentName = "Lycopene [As COLOR- Carotene]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E160e:
                        _EquivalentName = "Beta-apo-8-carotenal [As COLOR- Carotene]";
                        _AbstractInformation = "Lawful if used as 100% dry powder or granular or Lawful if vegetable oil is used as a solvent in liquid form as a hidden ingredient.  if pork gelatin is used as hidden ingredient or carrier .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E160f:
                        _EquivalentName = "Ethyl ester of Beta-apo-8-cartonoic acid [As COLOR- Carotene]";
                        _AbstractInformation = "Lawful if used as 100% dry powder or granular or Lawful if vegetable oil is used as a solvent in liquid form as a hidden ingredient.  if pork gelatin is used as hidden ingredient or carrier .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161a:
                        _EquivalentName = "Flavoxanthin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161b:
                        _EquivalentName = "Lutein [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry powder or granular.  if pork gelatin or pork glycerin is added in dry or liquid form .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161c:
                        _EquivalentName = "Cryptoxanthin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161d:
                        _EquivalentName = "Rubixanthin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161e:
                        _EquivalentName = "Violaxanthin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161f:
                        _EquivalentName = "Rhodoxanthin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E161g:
                        _EquivalentName = "Canthaxanthin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E162:
                        _EquivalentName = "Beetroot Red / Betanin [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E163:
                        _EquivalentName = "Anthocyanins [As COLOR]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E170:
                        _EquivalentName = "Calcium Carbonate (Chalk) [As COLOR- Inorganic]";
                        _AbstractInformation = "Lawful if used as 100% dry powder or granular.  if pork gelatin or pork glycerin is added in dry or liquid form .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E171:
                        _EquivalentName = "Titanium Dioxide [As COLOR- Inorganic] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E172:
                        _EquivalentName = "Iron Oxides and Hydroxides [As COLOR- Inorganic] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E173:
                        _EquivalentName = "Aluminium [As COLOR- Inorganic] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E174:
                        _EquivalentName = "Silver [As COLOR- Inorganic] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E175:
                        _EquivalentName = "Gold [As COLOR- Inorganic] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E180:
                        _EquivalentName = "Pigment Rubine / Lithol Rubine BK [As COLOR- Inorganic]";
                        _AbstractInformation = "Lawful if used as 100% dry color. Suspicion if used as liquid color, the solvent has to be Lawful .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E200:
                        _EquivalentName = "Sorbic Acid [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E201:
                        _EquivalentName = "Soduim Sorbate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E202:
                        _EquivalentName = "Potassium Sorbate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E203:
                        _EquivalentName = "Calcium Sorbate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E210:
                        _EquivalentName = "Benzoic Acid [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E211:
                        _EquivalentName = "Sodium Benzoate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E212:
                        _EquivalentName = "Potassium Benzoate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E213:
                        _EquivalentName = "Calcium Benzoate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if calcium obtained from mineral, Suspicion if it is obtained from bones.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E214:
                        _EquivalentName = "Ethyl 4-hydroxybenzoate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if used as 100% dry powder or granular.  if alcohol is used as a solvent";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E215:
                        _EquivalentName = "Ethyl 4-hydroxybenzoate, Sodium Salt[As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if used as 100% dry powder or granular.  if alcohol is used as a solvent";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E216:
                        _EquivalentName = "Propyl 4-hydroxybenzoate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if used as 100% dry powder or granular.  if alcohol is used as a solvent";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E217:
                        _EquivalentName = "Propyl 4-hydroxybenzoate, Sodium Salt [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if used as 100% dry powder or granular.  if alcohol is used as a solvent";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E218:
                        _EquivalentName = "Methyl 4-hydroxybenzoate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if used as 100% dry powder or granular.  if alcohol is used as a solvent";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E219:
                        _EquivalentName = "Methyl 4-hydroxybenzoate, Sodium Salt [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful, if used as 100% dry powder or granular.  if alcohol is used as a solvent";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E220:
                        _EquivalentName = "Sulphur Dioxide [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E221:
                        _EquivalentName = "Sodium Sulphite [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E222:
                        _EquivalentName = "Sodium Hydrogen Sulphite [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E223:
                        _EquivalentName = "Sodium Metabisulphite [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E224:
                        _EquivalentName = "Potassium Metabisulphite [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E226:
                        _EquivalentName = "Calcium Sulphite [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E227:
                        _EquivalentName = "Calcium Hydrogen Sulphite [As COLOR]";
                        _AbstractInformation = "Lawful, if calcium is obtained from mineral or chemicals. Suspicion if it is obtained from bones. .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E230:
                        _EquivalentName = "Biphenyl / Diphenyl [As COLOR]";
                        _AbstractInformation = "Lawful, if no alcohol is used as a solvent.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E231:
                        _EquivalentName = "2-Hydroxybiphenyl [As COLOR]";
                        _AbstractInformation = "Lawful, if no alcohol is used as a solvent.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E232:
                        _EquivalentName = "Sodium Biphenyl-2-yl Oxide [As COLOR]";
                        _AbstractInformation = "Lawful, if no alcohol is used as a solvent.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E233:
                        _EquivalentName = "2-(Thiazol-4-yl) Benzimidazole [As COLOR]";
                        _AbstractInformation = "Lawful, if no alcohol is used as a solvent.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E239:
                        _EquivalentName = "Hexamine [As PRESERVATIVE- other] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E249:
                        _EquivalentName = "Potassium Nitrate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E250:
                        _EquivalentName = "Sodium Nitrite [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E251:
                        _EquivalentName = "Sodium Nitrate [As PRESERVATIVE] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E260:
                        _EquivalentName = "Acetic Acid [As Miscellaneous - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E261:
                        _EquivalentName = "Potassium Acetate [As Miscellaneous - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E262:
                        _EquivalentName = "Potassium Hydrogen Diacetate [As Miscellaneous - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E263:
                        _EquivalentName = "Calcium Acetate [As Miscellaneous - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E270:
                        _EquivalentName = "Lactic Acid [As Miscellaneous - Acids] ";
                        _AbstractInformation = "Lawful if obtained other than whey. In USA it is always from non dairy source.";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E280:
                        _EquivalentName = "Propionic Acid [As Preservative - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E281:
                        _EquivalentName = "Sodium Propionate [As Preservative - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E282:
                        _EquivalentName = "Calcium Propionate [As Preservative- Acids] ";
                        _AbstractInformation = "Lawful if calcium obtained from mineral, Suspicion if it obtained from bones";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E283:
                        _EquivalentName = "Potassium Propionate [As Preservative - Acids] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E290:
                        _EquivalentName = "Carbon Dioxide [As Preservative - Acids] ";
                        _AbstractInformation = "Lawful. [But still its in research that whether its Lawful or not.]";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E300:
                        _EquivalentName = "L-Ascorbic Acid (Vitamin C) [As Antioxidants- Vitamin C] ";
                        _AbstractInformation = "Lawful. [But still its in research that whether its Lawful or not.]";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E301:
                        _EquivalentName = "Sodium-L-Ascorbate [As Antioxidants- Vitamin C and derivatives] ";
                        _AbstractInformation = "Lawful. [But still its in research that whether its Lawful or not.]";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E302:
                        _EquivalentName = "Calcium-L-Ascorbate [As Antioxidants- Vitamin C and derivatives]";
                        _AbstractInformation = "Lawful, if the calcium source is from mineral, Suspicion if it is from bones .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E304:
                        _EquivalentName = "Ascorbyl Palmitate [As Antioxidants- Vitamin C and derivatives]";
                        _AbstractInformation = "Lawful if saturated  fatty acid Palmitic acid is obtained from plant. Unlawful if palmitic acid is obtained from pork fat ";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E306:
                        _EquivalentName = "Natural Extracts rich in Tocopherols [As Antioxidants- Vitamin E]";
                        _AbstractInformation = "Lawful If Tocopherol is obtained from plant fat. Unlawful if Tocopherol is obtained from pork fat  ";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E307:
                        _EquivalentName = "Synthetic Alpha-Tocopherol [As Antioxidants- Vitamin E]";
                        _AbstractInformation = "Lawful only if it is made with all Lawful synthetic material without alcoholic fermentation synthetic method";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E308:
                        _EquivalentName = "Synthetic Gamma-Tocopherol [As Antioxidants- Vitamin E]";
                        _AbstractInformation = "Lawful only if it is made with all Lawful synthetic material without alcoholic fermentation synthetic method";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E309:
                        _EquivalentName = "Synthetic Delta-Tocopherol [As Antioxidants- Vitamin E]";
                        _AbstractInformation = "Lawful only if it is made with all Lawful synthetic material without alcoholic fermentation synthetic method";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E310:
                        _EquivalentName = "Propyl Gallate [As Antioxidants- other] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E311:
                        _EquivalentName = "Octyl Gallate [As Antioxidants- other]";
                        _AbstractInformation = "Lawful if obtained from nutgalls or plant secretion ";

                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E312:
                        _EquivalentName = "Dodecyl Gallate [As Antioxidants- other]";
                        _AbstractInformation = "Lawful if obtained from nutgalls or plant secretion. Unlawful if alcohol was used as solvent  ";

                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E320:
                        _EquivalentName = "Butylated Hydroxyanisole (BHA) [As Antioxidants- other]";
                        _AbstractInformation = "Lawful if only vegetable oil is used as a carrier. Unlawful if the carrier is from pork fat. It is not available as pure 100% chemical. ";

                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E321:
                        _EquivalentName = "Butylated Hydroxytoluene (BHT) [As Antioxidants- other]";
                        _AbstractInformation = "Lawful if only vegetable oil is used as a carrier. Unlawful if the carrier is from pork fat. It is not available as pure 100% chemical. ";

                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E322:
                        _EquivalentName = "Lecithin [As Emulsifiers and Stabilizers] ";
                        _AbstractInformation = "Lawful if obtained from soy fat or egg yolk in Europe. It is Lawful in USA because it is always obtained from soy fat. .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E325:
                        _EquivalentName = "Sodium Lactate [As Miscellaneous - Salts of Lactic Acid] ";
                        _AbstractInformation = "Lawful if the lactic acid from non dairy source .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E326:
                        _EquivalentName = "Potassium Lactate [As Miscellaneous - Salts of Lactic Acid] ";
                        _AbstractInformation = "Lawful if the lactic acid from non dairy source .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E327:
                        _EquivalentName = "Calcium Lactate [As Miscellaneous - Salts of Lactic Acid] ";
                        _AbstractInformation = "Lawful if the lactic acid from non dairy source and calcium from mineral .";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E330:
                        _EquivalentName = "Citric Acid [As Miscellaneous - Citric Acid and its Salts] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E331:
                        _EquivalentName = "Sodium Citrates [As Miscellaneous - Citric Acid and its Salts] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E332:
                        _EquivalentName = "Potassium Citrates [As Miscellaneous - Citric Acid and its Salts] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E333:
                        _EquivalentName = "Calcium Citrates [As Miscellaneous - Citric Acid and its Salts] ";
                        _AbstractInformation = "Lawful if calcium source is not from bones";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E334:
                        _EquivalentName = "Tartaric Acid [As Miscellaneous - Tartaric Acid and its Salts] ";
                        _AbstractInformation = "Lawful, if it is not obtained from wine by-product, in USA it is Lawful because it is obtained from un-fermented grapes.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E335:
                        _EquivalentName = "Sodium Tartrates [As Miscellaneous - Tartaric Acid and its Salts] ";
                        _AbstractInformation = "Lawful, if it is not obtained from wine by-product, in USA it is Lawful because it is obtained from un-fermented grapes.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E336:
                        _EquivalentName = "Potassium Tartrates (Cream of Tartar) [As Miscellaneous - Tartaric Acid and its Salts] ";
                        _AbstractInformation = "Lawful, if it is not obtained from wine by-product, in USA it is Lawful because it is obtained from un-fermented grapes.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E337:
                        _EquivalentName = "Potassium Sodium Tartrates [As Miscellaneous - Tartaric Acid and its Salts] ";
                        _AbstractInformation = "Lawful, if it is not obtained from wine by-product, in USA it is Lawful because it is obtained from un-fermented grapes.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E338:
                        _EquivalentName = "Orthophosphoric Acid [As Miscellaneous - Phosphoric Acid and its Salts] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E339:
                        _EquivalentName = "Sodium Phosphates [As Miscellaneous - Phosphoric Acid and its Salts] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E340:
                        _EquivalentName = "Potassium Phosphates [As Miscellaneous - Phosphoric Acid and its Salts] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E341:
                        _EquivalentName = "Calcium Phosphates [As Miscellaneous - Phosphoric Acid and its Salts] ";
                        _AbstractInformation = "Lawful if calcium from mineral source";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E400:
                        _EquivalentName = "Alginic Acid [As Emulsifiers and Stabilizers - Alginates] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E401:
                        _EquivalentName = "Sodium Alginate [As Emulsifiers and Stabilizers - Alginates] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E402:
                        _EquivalentName = "Potassium Alginate [As Emulsifiers and Stabilizers - Alginates] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E403:
                        _EquivalentName = "Ammonium Alginate [As Emulsifiers and Stabilizers - Alginates] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E404:
                        _EquivalentName = "Calcium Alginate [As Emulsifiers and Stabilizers - Alginates] ";
                        _AbstractInformation = "Lawful if calcium source is from mineral";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E405:
                        _EquivalentName = "Propane-1,2-Diol Alginate [As Emulsifiers and Stabilizers - Alginates] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E406:
                        _EquivalentName = "Agar [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E407:
                        _EquivalentName = "Carrageenan [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E410:
                        _EquivalentName = "Locust Bean Gum (Carob Gum) [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E412:
                        _EquivalentName = "Guar Gum [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E413:
                        _EquivalentName = "Tragacanth [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E414:
                        _EquivalentName = "Gum Acacia (Gum Arabic) [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E415:
                        _EquivalentName = "Xanthan Gum [As Emulsifiers and Stabilizers - other plant gums] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E420:
                        _EquivalentName = "Sorbitol [As Sugar Alcohols] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E421:
                        _EquivalentName = "Mannitol [As Sugar Alcohols] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E422:
                        _EquivalentName = "Glycerol [As Sugar Alcohols]";
                        _AbstractInformation = "Suspicion, called Glycerin in USA, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E440a:
                        _EquivalentName = "Pectin [As Emulsifiers and Stabilizers - Pectin and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E440b:
                        _EquivalentName = "Amidated Pectin [As Emulsifiers and Stabilizers - Pectin and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E450a_b_c:
                        _EquivalentName = "Sodium and Potassium Phosphates and Polyphosphates [As Miscellaneous] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E460:
                        _EquivalentName = "Microcrystalline / Powdered Cellulose [As Emulsifiers and Stabilizers - Cellulose and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E461:
                        _EquivalentName = "Methylcellulose [As Emulsifiers and Stabilizers - Cellulose and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E463:
                        _EquivalentName = "Hydroxypropylcellulose [As Emulsifiers and Stabilizers - Cellulose and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E464:
                        _EquivalentName = "Hydroxypropyl-Methylcellulose [As Emulsifiers and Stabilizers - Cellulose and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E465:
                        _EquivalentName = "Ethylmethylcellulose [As Emulsifiers and Stabilizers - Cellulose and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E466:
                        _EquivalentName = "Carboxymethylcellulose, Sodium Salt [As Emulsifiers and Stabilizers - Cellulose and derivatives] ";
                        _AbstractInformation = "Lawful.";


                        _CodeIntegrity = Integrity.Lawful; break;
                    case Ecode.E470:
                        _EquivalentName = "Sodium, Potassium and Calcium Salts of Fatty Acids [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E471:
                        _EquivalentName = "Mono-and Diglycerides of Fatty Acids [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E472:
                        _EquivalentName = "Various Esters of Mono-and Diglycerides of Fatty Acids [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";
                        _CodeIntegrity = Integrity.Suspect; break;

                    case Ecode.E473:
                        _EquivalentName = "Sucrose Esters of Fatty Acids [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";
                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E474:
                        _EquivalentName = "Sucroglycerides [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E475:
                        _EquivalentName = "Polyglycerol Esters of Fatty Acids [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E477:
                        _EquivalentName = "Propane-1,2-Diol Esters of Fatty Acids [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E481:
                        _EquivalentName = "Sodium Stearoyl-2-Lactylate [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                    case Ecode.E482:
                        _EquivalentName = "Calcium Stearoyl-2-Lactylate [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";
                        _CodeIntegrity = Integrity.Suspect; break;

                    case Ecode.E483:
                        _EquivalentName = "Stearyl Tartrate [As Emulsifiers and Stabilizers - salts or Esters of Fatty Acids]";
                        _AbstractInformation = "Suspicion, Lawful if it is from plant fat, Unlawful if it is from pork fat .";


                        _CodeIntegrity = Integrity.Suspect; break;
                }
            /*}
            catch
            {
                goto Er;
            }
        Er:
            throw HelperFunctions.InvalidEcodeException;
        */
        }

        /// <summary>
        /// Returns the instance of this EcodeInformation.
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            return (string.Format("{0}, {1}", _AdvertName, _AbstractInformation));
        }

    }

}