// context/CvContext.tsx
"use client";
import { createContext, useContext, useState } from "react";

const CvContext = createContext<any>(null);

export function CvProvider({ children }: { children: React.ReactNode }) {
  const [step, setStep] = useState(1);
  const [cvData, setCvData] = useState({
    personal: {},
    education: [],
    work: [],
  });

  const nextStep = () => setStep((s) => s + 1);
  const prevStep = () => setStep((s) => s - 1);

  return (
    <CvContext.Provider value={{ step, setStep, nextStep, prevStep, cvData, setCvData }}>
      {children}
    </CvContext.Provider>
  );
}

// Hook a könnyebb eléréshez
export const useCv = () => useContext(CvContext);
