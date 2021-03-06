﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomNumberGenerators;

namespace DAL.Generator
{
    [Serializable]
    public class IdGenerator : IGenerator
    {
        private IEnumerable<int> generatedId;
        private int currentPos;
        public IdGenerator(INumberGenerator numberGenerator)
        {
            generatedId = numberGenerator.GenerateNumberEnumerable().Take(100).ToList();
            currentPos = 0;
        }
        public int GenerateId()
        {
            return generatedId.Skip(currentPos++).Take(1).FirstOrDefault();
        }
        public void SetIdPosition(int idPosition)
        {
            currentPos = idPosition;
        }
        public int GetCurrentPosition()
        {
            return currentPos;
        }
    }
}
