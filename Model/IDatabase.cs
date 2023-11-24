﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab6_Starter.Model
{
    public interface IDatabase
    {
        ObservableCollection<Airport> SelectAllAirports();
        ObservableCollection<Airport> SelectAllWiAirports();
        Airport SelectAirport(String id);
        Airport SelectWisconsinAirport(String id);
        AirportAdditionError InsertAirport(Airport airport);
        AirportDeletionError DeleteAirport(Airport airport);
        AirportEditError UpdateAirport(Airport replacementAirport);
        ObservableCollection<Resource> SelectAllResources();
    }
}