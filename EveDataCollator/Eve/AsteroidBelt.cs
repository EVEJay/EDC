﻿using EveDataCollator.Data;

namespace EveDataCollator.Eve
{
    public class AsteroidBelt
    {
        // position
        //      - X,Y,Z
        // statistics
        // typeID
        
        public int Id { get; set; }
        public DecVector3 Position { get; set; }
        public Statistics Statistics { get; set; } = new();
        public int TypeId { get; set; }
    }
}