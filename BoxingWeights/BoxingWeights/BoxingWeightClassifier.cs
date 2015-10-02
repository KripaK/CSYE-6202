using System;
namespace BoxingWeights
{
	public class BoxingWeightClassifier
	{
		public string ClassifyBoxingWeight(int weightInPounds)
		{
            string type = "Heavyweight";
            if (weightInPounds <= 105)
            {
                return "Strawweight and " + type;
            }
            else if (weightInPounds > 105 && weightInPounds <= 108)
            {
                return "JuniorFlyweight and " + type;
            }
            else if (weightInPounds > 108 && weightInPounds <= 112)
            {
                return "Flyweight and " + type;
            }
            else if (weightInPounds > 112 && weightInPounds <= 115)
            {
                return "JuniorBantamweight and " + type;
            }
            else if (weightInPounds > 115 && weightInPounds <= 118)
            {
                return "Bantamweight and " + type;
            }
            else if (weightInPounds > 118 && weightInPounds <= 120)
            {
                return "JuniorFeatherweight and " + type;
            }
            else if (weightInPounds > 120 && weightInPounds <= 126)
            {
                return "Featherweight and " + type;
            }
            else if (weightInPounds > 126 && weightInPounds <= 130)
            {
                return "JuniorLightweight and " + type;
            }
            else if (weightInPounds > 130 && weightInPounds <= 135)
            {
                return "Lightweight and " + type;
            }
            else if (weightInPounds > 135 && weightInPounds <= 140)
            {
                return "JuniorWelterweight and " + type;
            }
            else if (weightInPounds > 140 && weightInPounds <= 147)
            {
                return "Welterweight and " + type;
            }
            else if (weightInPounds > 147 && weightInPounds <= 150)
            {
                return "Welterweight and " + type;
            }
            else if (weightInPounds > 150 && weightInPounds <= 154)
            {
                return "JuniorMiddleweight and " + type;
            }
            else if (weightInPounds > 154 && weightInPounds <= 160)
            {
                return "Middleweight and " + type;
            }
            else if (weightInPounds > 160 && weightInPounds <= 168)
            {
                return "SuperMiddleweight and " + type;
            }
            else if (weightInPounds > 168 && weightInPounds <= 175)
            {
                return "LightHeavyweight and " + type;
            }
            else if (weightInPounds > 175 && weightInPounds <= 200)
            {
                return "Cruiserweight and " + type;
            }
            else
                return type;
            // your solution/implementation should go in here
		}
	}
}
