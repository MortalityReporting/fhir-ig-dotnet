﻿using System;
using Hl7.Fhir.Model;

namespace GaTech.Chai.Share.Common
{
    public class CodeSystems
    {
        public class ObservationCategory
        {
            public static string officialUrl = "http://terminology.hl7.org/CodeSystem/observation-category";

            public static Coding SocialHistory = new (officialUrl, "social-history", "Social History");
            public static Coding VitalSigns = new (officialUrl, "vital-signs", "Vital Signs");
            public static Coding Imaging = new(officialUrl, "imaging", "Imaging");
            public static Coding Laboratory = new(officialUrl, "laboratory", "Laboratory");
            public static Coding Procedure = new(officialUrl, "procedure", "Procedure");
            public static Coding Survey = new(officialUrl, "survey", "Survey");
            public static Coding Exam = new(officialUrl, "exam", "Exam");
            public static Coding Therapy = new(officialUrl, "therapy", "Therapy");
            public static Coding Activity = new(officialUrl, "activity", "Activity");
        }
    }

    public class ValueSets
    {
        public class DiagnosticServiceSections
        {
            public static string officialUrl = "http://terminology.hl7.org/CodeSystem/v2-0074";

            public static Coding Audiology = new(officialUrl, "AU", "Audiology");
            public static Coding BloodGases = new (officialUrl, "BG", "Blood Gases");
            public static Coding BloodBank = new (officialUrl, "BLB", "Blood Bank");
            public static Coding Cytogenetics = new(officialUrl, "CG", "Cytogenetics");
            public static Coding Chemistry = new(officialUrl, "CH", "Chemistry");
            public static Coding Cytopathology = new(officialUrl, "CP", "Cytopathology");
            public static Coding CATScan = new (officialUrl, "CT", "CAT Scan");
            public static Coding CardiacCatheterization = new (officialUrl, "CTH", "Cardiac Catheterization");
            public static Coding CardiacUltrasound = new (officialUrl, "CUS", "Cardiac Ultrasound");
            public static Coding Electrocardiac = new(officialUrl, "EC", "Electrocardiac (e.g., EKG, EEC, Holter)");
            public static Coding Electroneuro = new(officialUrl, "EN", "Electroneuro (EEG, EMG,EP,PSG)");
            public static Coding Genetics = new(officialUrl, "GE", "Genetics");
            public static Coding Hematology = new(officialUrl, "HM", "Hematology");
            public static Coding BedsideIcuMonitoring = new(officialUrl, "ICU", "Bedside ICU Monitoring");
            public static Coding Immunology = new(officialUrl, "IMM", "Immunology");
            public static Coding Laboratory = new(officialUrl, "LAB", "Laboratory");
            public static Coding Microbiology = new(officialUrl, "MB", "Microbiology");
            public static Coding Mycobacteriology = new(officialUrl, "MCB", "Mycobacteriology");
            public static Coding Mycology = new(officialUrl, "MYC", "Mycology");
            public static Coding NuclearMagneticResonance = new(officialUrl, "NMR", "Nuclear Magnetic Resonance");
            public static Coding NuclearMedicineScan = new(officialUrl, "NMS", "Nuclear Medicine Scan");
            public static Coding NursingServiceMeasures = new(officialUrl, "NRS", "Nursing Service Measures");
            public static Coding OutsideLab = new (officialUrl, "OSL", "Outside Lab");
            public static Coding OccupationalTherapy = new (officialUrl, "OT", "Occupational Therapy");
            public static Coding Other = new(officialUrl, "OTH", "Other");
            public static Coding OBUltrasound = new (officialUrl, "OUS", "OB Ultrasound");
            public static Coding PulmonaryFunction = new (officialUrl, "PF", "Pulmonary Function");
            public static Coding Pharmacy = new(officialUrl, "PHR", "Pharmacy");
            public static Coding Physician = new (officialUrl, "PHY", "Physician (Hx. Dx, admission note, etc.)");
            public static Coding PhysicalTherapy = new (officialUrl, "PT", "Physical Therapy");
            public static Coding Radiology = new(officialUrl, "RAD", "Radiology");
            public static Coding RespiratoryCare = new (officialUrl, "RC", "Respiratory Care (therapy)");
            public static Coding RadiationTherapy = new (officialUrl, "RT", "Radiation Therapy");
            public static Coding RadiologyUltrasound = new (officialUrl, "RUS", "Radiology Ultrasound");
            public static Coding Radiograph = new(officialUrl, "RX", "Radiograph");
            public static Coding SurgicalPathology = new (officialUrl, "SP", "Surgical Pathology");
            public static Coding Serology = new(officialUrl, "SR", "Serology");
            public static Coding Toxicology = new(officialUrl, "TX", "Toxicology");
            public static Coding Virology = new(officialUrl, "VR", "Virology");
            public static Coding VascularUltrasound = new (officialUrl, "VUS", "Vascular Ultrasound");
            public static Coding Cineradiograph = new(officialUrl, "XRC", "Cineradiograph");
        }
    }
}
