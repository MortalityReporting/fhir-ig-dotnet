﻿using System;
using GaTech.Chai.Share;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using static GaTech.Chai.Share.CodeSystems;

namespace GaTech.Chai.Vrdr
{

    public class VrdrComponentCs
    {
        public const string officialUrl = "http://hl7.org/fhir/us/vrdr/CodeSystem/vrdr-component-cs";

        public static CodeableConcept Position = new(officialUrl, "position", "position", null);
        public static CodeableConcept LineNumber = new(officialUrl, "lineNumber", "line number", null);
        public static CodeableConcept ECodeIndicator = new(officialUrl, "eCodeIndicator", "e Code Indicator", null);
        public static CodeableConcept WouldBeUnderlyingCauseOfDeathWithoutPregnancy = new(officialUrl, "wouldBeUnderlyingCauseOfDeathWithoutPregnancy", "Would be underlying cause of death without pregnancy", null);
        public static CodeableConcept EmergingIssue1_1 = new(officialUrl, "EmergingIssue1_1", "EmergingIssue1_1", null);
        public static CodeableConcept EmergingIssue1_2 = new(officialUrl, "EmergingIssue1_2", "EmergingIssue1_2", null);
        public static CodeableConcept EmergingIssue1_3 = new(officialUrl, "EmergingIssue1_3", "EmergingIssue1_3", null);
        public static CodeableConcept EmergingIssue1_4 = new(officialUrl, "EmergingIssue1_4", "EmergingIssue1_4", null);
        public static CodeableConcept EmergingIssue1_5 = new(officialUrl, "EmergingIssue1_5", "EmergingIssue1_5", null);
        public static CodeableConcept EmergingIssue1_6 = new(officialUrl, "EmergingIssue1_6", "EmergingIssue1_6", null);
        public static CodeableConcept EmergingIssue1_7 = new(officialUrl, "EmergingIssue1_7", "EmergingIssue1_7", null);
        public static CodeableConcept EmergingIssue1_8 = new(officialUrl, "EmergingIssue1_8", "EmergingIssue1_8", null);
        public static CodeableConcept EmergingIssue8_1 = new(officialUrl, "EmergingIssue8_1", "EmergingIssue8_1", null);
        public static CodeableConcept EmergingIssue8_2 = new(officialUrl, "EmergingIssue8_2", "EmergingIssue8_2", null);
        public static CodeableConcept EmergingIssue8_3 = new(officialUrl, "EmergingIssue8_3", "EmergingIssue8_3", null);
        public static CodeableConcept EmergingIssue20 = new(officialUrl, "EmergingIssue20", "EmergingIssue20", null);
        public static CodeableConcept FirstEditedCode = new(officialUrl, "FirstEditedCode", "First Edited Race Code", null);
        public static CodeableConcept SecondEditedCode = new(officialUrl, "SecondEditedCode", "Second Edited Race Code", null);
        public static CodeableConcept ThirdEditedCode = new(officialUrl, "ThirdEditedCode", "Third Edited Race Code", null);
        public static CodeableConcept FourthEditedCode = new(officialUrl, "FourthEditedCode", "Fourth Edited Race Code", null);
        public static CodeableConcept FifthEditedCode = new(officialUrl, "FifthEditedCode", "Fifth Edited Race Code", null);
        public static CodeableConcept SixthEditedCode = new(officialUrl, "SixthEditedCode", "Sixth Edited Race Code", null);
        public static CodeableConcept SeventhEditedCode = new(officialUrl, "SeventhEditedCode", "Seventh Edited Race Code", null);
        public static CodeableConcept EighthEditedCode = new(officialUrl, "EighthEditedCode", "Eighth Edited Race Code", null);
        public static CodeableConcept FirstAmericanIndianCode = new(officialUrl, "FirstAmericanIndianCode", "First Edited American Indian Race Code", null);
        public static CodeableConcept SecondAmericanIndianCode = new(officialUrl, "SecondAmericanIndianCode", "Second Edited American Indian Race Code", null);
        public static CodeableConcept FirstOtherAsianCode = new(officialUrl, "FirstOtherAsianCode", "First Edited Other Asian Race Code", null);
        public static CodeableConcept SecondOtherAsianCode = new(officialUrl, "SecondOtherAsianCode", "Second Edited Other Asian Race Race Code", null);
        public static CodeableConcept FirstOtherPacificIslanderCode = new(officialUrl, "FirstOtherPacificIslanderCode", "First Edited Other Pacific Islander Race Code", null);
        public static CodeableConcept SecondOtherPacificIslanderCode = new(officialUrl, "SecondOtherPacificIslanderCode", "First Edited Other Pacific Islander Race Code", null);
        public static CodeableConcept FirstOtherRaceCode = new(officialUrl, "FirstOtherRaceCode", "First Edited Other Race Code", null);
        public static CodeableConcept SecondOtherRaceCode = new(officialUrl, "SecondOtherRaceCode", "First Edited Other Race Code", null);
        public static CodeableConcept RaceRecode40 = new(officialUrl, "RaceRecode40", "Race Recode 40", null);
        public static CodeableConcept HispanicCode = new(officialUrl, "HispanicCode", "Hispanic Code", null);
        public static CodeableConcept HispanicCodeForLiteral = new(officialUrl, "HispanicCodeForLiteral", "Hispanic Code for Literal", null);
        public static CodeableConcept RACEMVR = new(officialUrl, "RACEMVR", "Race Missing Value Reason", null);
        public static CodeableConcept HispanicMexican = new(officialUrl, "HispanicMexican", "Hispanic Mexican", null);
        public static CodeableConcept HispanicPuertoRican = new(officialUrl, "HispanicPuertoRican", "Hispanic Puerto Rican", null);
        public static CodeableConcept HispanicCuban = new(officialUrl, "HispanicCuban", "Hispanic Cuban", null);
        public static CodeableConcept HispanicOther = new(officialUrl, "HispanicOther", "Hispanic Other", null);
        public static CodeableConcept HispanicLiteral = new(officialUrl, "HispanicLiteral", "Hispanic Literal", null);
        public static CodeableConcept White = new(officialUrl, "White", "White", null);
        public static CodeableConcept BlackOrAfricanAmerican = new(officialUrl, "BlackOrAfricanAmerican", "Black Or African American", null);
        public static CodeableConcept AmericanIndianOrAlaskanNative = new(officialUrl, "AmericanIndianOrAlaskanNative", "American Indian Or Alaska Native", null);
        public static CodeableConcept AsianIndian = new(officialUrl, "AsianIndian", "Asian Indian", null);
        public static CodeableConcept Chinese = new(officialUrl, "Chinese", "Chinese", null);
        public static CodeableConcept Filipino = new(officialUrl, "Filipino", "Filipino", null);
        public static CodeableConcept Japanese = new(officialUrl, "Japanese", "Japanese", null);
        public static CodeableConcept Korean = new(officialUrl, "Korean", "Korean", null);
        public static CodeableConcept Vietnamese = new(officialUrl, "Vietnamese", "Vietnamese", null);
        public static CodeableConcept OtherAsian = new(officialUrl, "OtherAsian", "OtherAsian", null);
        public static CodeableConcept NativeHawaiian = new(officialUrl, "NativeHawaiian", "Native Hawaiian", null);
        public static CodeableConcept GuamanianOrChamorro = new(officialUrl, "GuamanianOrChamorro", "Guamanian Or Chamorro", null);
        public static CodeableConcept Samoan = new(officialUrl, "Samoan", "Samoan", null);
        public static CodeableConcept OtherPacificIslander = new(officialUrl, "OtherPacificIslander", "Other Pacific Islander", null);
        public static CodeableConcept OtherRace = new(officialUrl, "OtherRace", "Other Race", null);
        public static CodeableConcept FirstAmericanIndianOrAlaskanNativeLiteral = new(officialUrl, "FirstAmericanIndianOrAlaskanNativeLiteral", "First American Indian Or Alaska Native Literal", null);
        public static CodeableConcept SecondAmericanIndianOrAlaskanNativeLiteral = new(officialUrl, "SecondAmericanIndianOrAlaskanNativeLiteral", "Second American Indian Or Alaska Native Literal", null);
        public static CodeableConcept FirstOtherAsianLiteral = new(officialUrl, "FirstOtherAsianLiteral", "First Other Asian Literal", null);
        public static CodeableConcept SecondOtherAsianLiteral = new(officialUrl, "SecondOtherAsianLiteral", "Second Other Asian Literal", null);
        public static CodeableConcept FirstOtherPacificIslanderLiteral = new(officialUrl, "FirstOtherPacificIslanderLiteral", "First Other Pacific Islander Literal", null);
        public static CodeableConcept SecondOtherPacificIslanderLiteral = new(officialUrl, "SecondOtherPacificIslanderLiteral", "Second Other Pacific Islander Literal", null);
        public static CodeableConcept FirstOtherRaceLiteral = new(officialUrl, "FirstOtherRaceLiteral", "First Other Race Literal", null);
        public static CodeableConcept SecondOtherRaceLiteral = new(officialUrl, "SecondOtherRaceLiteral", "Second Other Race Literal", null);
    }

    public class VrdrTransportationIncidentRoleVs
    {
        public const string officialUrl = "http://hl7.org/fhir/us/vrdr/ValueSet/vrdr-transportation-incident-role-vs";

        public static CodeableConcept VehicleDriver = new(UriString.SCT, "236320001", "Vehicle driver", null);
        public static CodeableConcept Passenger = new(UriString.SCT, "257500003", "Passenger", null);
        public static CodeableConcept Pedestrian = new(UriString.SCT, "257518000", "Pedestrian", null);
        public static CodeableConcept Other = V3NullFlavor.Other; 
        public static CodeableConcept Unknown = V3NullFlavor.Unknown;
        public static CodeableConcept NotApplicable = V3NullFlavor.NotApplicable;
    }

    public class ValueSetAdministrativeGenderMaxVs
    {
        public const string officialUrl = "http://hl7.org/fhir/us/vrdr/ValueSet/ValueSet-administrative-gender-max-vs";

        public static CodeableConcept F = V3AdministrativeGender.F;
        public static CodeableConcept M = V3AdministrativeGender.M;
        public static CodeableConcept UnknownV3 = V3NullFlavor.Unknown;
        public static CodeableConcept Female = new(AdministrativeGender.Female.GetEnumSystem(), AdministrativeGender.Female.GetEnumCode(), AdministrativeGender.Female.GetEnumDescription(), null);
        public static CodeableConcept Mail = new(AdministrativeGender.Male.GetEnumSystem(), AdministrativeGender.Male.GetEnumCode(), AdministrativeGender.Male.GetEnumDescription(), null);
        public static CodeableConcept UnknownAdministrative = new(AdministrativeGender.Unknown.GetEnumSystem(), AdministrativeGender.Unknown.GetEnumCode(), AdministrativeGender.Unknown.GetEnumDescription(), null);
    }

    public class VrdrMannerOfDeathVs
    {
        public static CodeableConcept NaturalDeath = new(UriString.SCT, "38605008", "Natural death", null);
        public static CodeableConcept AccidentalDeath = new(UriString.SCT, "7878000", "Accidental death", null);
        public static CodeableConcept Suicide = new(UriString.SCT, "44301001", "Suicide", null);
        public static CodeableConcept Homicide = new(UriString.SCT, "27935005", "Homicide", null);
        public static CodeableConcept PatientAwaitingInvestigation = new(UriString.SCT, "185973002", "Patient awaiting investigation", null);
        public static CodeableConcept DeathMannerUndetermined = new(UriString.SCT, "65037004", "Death, manner undetermined", null);
    }

    public class VrdrCs {
        public static CodeableConcept MannerOfDeathLoinc = new(UriString.LOINC, "69449-7");
        public static CodeableConcept DeathCertificationSCT = new(UriString.SCT, "308646001");
        public static CodeableConcept CauseOfDeath = new(UriString.LOINC, "69453-9");
        public static CodeableConcept AgeAtDeath = new(UriString.LOINC, "39016-1");
        public static CodeableConcept InjuryIncident = new(UriString.LOINC, "11374-6");
    }

    public class VrdrCertifierTypesVs
    {
        public static CodeableConcept DeathCertByCME = new(UriString.SCT, "455381000124109", "Death certification by medical examiner or coroner (procedure)", null);
        public static CodeableConcept DeathCertAndVerifByPhysician = new(UriString.SCT, "434641000124105", "Death certification and verification by physician (procedure)", null);
        public static CodeableConcept DeathCertByPhysician = new(UriString.SCT, "434651000124107", "Death certification by physician (procedure)", null);
        public static CodeableConcept Other = V3NullFlavor.Other;
    }

    public class VrdrLocationTypeCs
    {
        public static CodeableConcept InjuryLocation = new("http://hl7.org/fhir/us/vrdr/CodeSystem/vrdr-location-type-cs", "injury", "Injury Location", null);
        public static CodeableConcept DispositionLocation = new("http://hl7.org/fhir/us/vrdr/CodeSystem/vrdr-location-type-cs", "disposition", "Disposition Location", null);
        public static CodeableConcept DeathLocation = new("http://hl7.org/fhir/us/vrdr/CodeSystem/vrdr-location-type-cs", "death", "Death Location", null);
    }

    public class VrdrInjuryIncidentComponentsCs
    {
        public static CodeableConcept PlaceOfInjury = new(UriString.LOINC, "69450-5");
        public static CodeableConcept WorkInjuryIndicator = new(UriString.LOINC, "69444-8");
        public static CodeableConcept TransportationRole = new(UriString.LOINC, "69451-3");
    }
}
