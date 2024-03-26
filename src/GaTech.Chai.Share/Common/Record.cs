﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;

namespace GaTech.Chai.Share.Common;

public class Record
{
    readonly static Dictionary<string, Resource> resources = new ();

    public static Dictionary<string, Resource> GetResources()
    {
        return resources;
    }

    public static void AddResources(string key, Resource resource)
    {
        resources[key] = resource;
    }

}
