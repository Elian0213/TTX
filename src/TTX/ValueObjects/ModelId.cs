﻿namespace TTX.ValueObjects
{
    public class ModelId : ValueObject<int>
    {
        public static ModelId Create(int value)
        {
            return new ModelId { Value = value };
        }

        public static implicit operator ModelId(int value)
        {
            return Create(value);
        }

        public static implicit operator int(ModelId modelId)
        {
            return modelId.Value;
        }
    }
}