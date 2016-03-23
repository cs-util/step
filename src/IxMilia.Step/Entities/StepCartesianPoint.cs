﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace IxMilia.Step.Entities
{
    public class StepCartesianPoint : StepTriple
    {
        public override StepEntityType EntityType => StepEntityType.CartesianPoint;
        protected override int MinimumValueCount => 1;

        private StepCartesianPoint()
        {
        }

        public StepCartesianPoint(string name, double x, double y, double z)
            : base(name, x, y, z)
        {
        }

        internal static StepCartesianPoint CreateFromMacro(StepMacro macro)
        {
            return (StepCartesianPoint)AssignTo(new StepCartesianPoint(), macro);
        }
    }
}