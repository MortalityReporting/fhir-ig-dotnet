﻿using System;
using Hl7.Fhir.Model;
using Newtonsoft.Json.Linq;

namespace GaTech.Chai.Vrdr
{
    public static class ObservationPartialDateTimeExtensions
    {
        /// <summary>
        /// Partial DateTime Extension on Observation.valueDateTime
        /// </summary>
        public static  Extension GetPartialDateTime(this Observation observation)
        {
            FhirDateTime deathDateTiem = (FhirDateTime)observation.Effective;

            return deathDateTiem.GetExtension(VrdrUrls.partialDateTimeUrl);
        }

        public static Extension SetPartialDateTime(this Observation observation, DataType year, DataType month, DataType day, DataType time)
        {
            Extension partialDateTimeExt = new Extension { Url = VrdrUrls.partialDateTimeUrl };

            if (year is UnsignedInt)
            {
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeYearUrl, (UnsignedInt)year);
            }
            else if (year is Code)
            {
                // This is data-absent-reason
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeYearUrl, null)
                    .AddExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason", year);
            }

            if (month is UnsignedInt)
            {
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeMonthUrl, (UnsignedInt)month);
            }
            else if (month is Code)
            {
                // This is data-absent-reason
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeMonthUrl, null)
                    .AddExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason", month);
            }

            if (day is UnsignedInt)
            {
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeDayUrl, (UnsignedInt)day);
            }
            else if (day is Code)
            {
                // This is data-absent-reason
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeDayUrl, null)
                    .AddExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason", day);
            }

            if (time is Time)
            {
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeTimeUrl, time);
            }
            else if (time is Code)
            {
                // This is data-absent-reason
                partialDateTimeExt.AddExtension(VrdrUrls.partialDateTimeTimeUrl, null)
                    .AddExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason", time);
            }

            if (observation.Effective == null)
            {
                observation.Effective = new FhirDateTime();
            }

            FhirDateTime valueDateTime = observation.Effective as FhirDateTime;
            valueDateTime.Extension.Add(partialDateTimeExt);

            return partialDateTimeExt;
        }
    }
}

