"use client";
import { useState } from "react";
import PersonalInfoPage from "./pages/CV_Pages/PersonalInfo";
import EducationPage from "./pages/CV_Pages/Education";
import WorkExperiencePage from "./pages/CV_Pages/WorkExperience";
import TemplateSelector from "./pages/CV_Pages/TemplateSelector";

export default function HomePage() {
  const [step, setStep] = useState(1);
  const [cvData, setCvData] = useState<any>({
    personal: {},
    education: [],
    experience: [],
    skills: [],
  });

  const nextStep = () => setStep((prev) => Math.min(prev + 1, 5));
  const prevStep = () => setStep((prev) => Math.max(prev - 1, 1));

  const handleSave = (data: any) => {
    const newCvData = { ...cvData, ...data };
    setCvData(newCvData);

    // JSON mentése
    const blob = new Blob([JSON.stringify(newCvData, null, 2)], {
      type: "application/json",
    });
    const url = URL.createObjectURL(blob);
    const a = document.createElement("a");
    a.href = url;
    a.download = "cv.json";
    a.click();
    URL.revokeObjectURL(url);
  };

  return (
    <div className="min-h-screen flex items-center justify-center text-black bg-gray-50 p-6">
      <div className="bg-white p-8 rounded-xl shadow-lg w-full max-w-xl">
        {step === 1 && (
          <PersonalInfoPage
            onNext={nextStep}
            cvData={cvData}
            setCvData={setCvData}
          />
        )}
        {step === 2 && (
          <EducationPage
            onNext={nextStep}
            onBack={prevStep}
            cvData={cvData}
            setCvData={setCvData}
          />
        )}
        {step === 3 && (
          <>
            <WorkExperiencePage
              onBack={prevStep}
              onNext={nextStep}
              onSave={handleSave}
              cvData={cvData}
              setCvData={setCvData}
            />
          </>
        )}
        {step === 4 && 
          <TemplateSelector cvData={cvData} />
        }
      </div>
    </div>
  );
}
