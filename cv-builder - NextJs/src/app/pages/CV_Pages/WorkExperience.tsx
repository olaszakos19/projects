"use client";
import NextButton from "@/app/components/Buttons/NextButton";
import { useState } from "react";
import { useForm } from "react-hook-form";


export default function Step3({ onBack,onNext, cvData, setCvData }: any) {

  const [skills, setSkills] = useState(cvData.skills?.join(", ") || "");


  const {register,handleSubmit,reset} = useForm({
    defaultValues: {
      company: "",
      position: "",
      description: "",
      startDate: "",
      endDate: "",
       
    },
  });


  const addExperience = (data: any) => {
    if (!data) return;
    setCvData((prev: any) => ({
      ...prev,
      experience: [...(prev.experience || []), data],
    }));
    reset();
  };

 

  const onSubmit = () => {
    onNext();
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <h2 className="text-xl font-bold mb-4">Tapasztalatok & Készségek</h2>

      {/* Meglévő tapasztalatok listája */}
     {Array.isArray(cvData.education) &&
        cvData.experience.map((exp, i) =>  (
        <div key={i} className="p-3 border rounded bg-gray-50">
          <div className="font-semibold">{exp.position}</div>
          <div className="text-sm text-gray-700">{exp.company}</div>
          <div className="text-sm text-gray-500">
            {exp.startDate} – {exp.endDate}
          </div>
        </div>
      ))}

      {/* Új tapasztalat hozzáadása */}
      <input
        {...register("position")}
        placeholder="Pozíció"
        className="border p-2 w-full rounded"
      />
      <input
        {...register("company")}
        placeholder="Cég"
        className="border p-2 w-full rounded"
      />

      <div className="flex gap-4">
        <div className="flex flex-col flex-1">
          <label className="text-sm font-medium mb-1 text-gray-700">Kezdés</label>
          <input
            type="date"
            {...register("startDate")}
            className="border p-2 rounded w-full"
          />
        </div>

        <div className="flex flex-col flex-1">
          <label className="text-sm font-medium mb-1 text-gray-700">Vége</label>
          <input
            type="date"
            {...register("endDate")}
            className="border p-2 rounded w-full"
          />
        </div>
      </div>

      <button
        type="button"
        onClick={handleSubmit(addExperience)}
        className="bg-gray-300 px-3 py-2 rounded hover:bg-gray-400 w-full"
      >
        Hozzáadás
      </button>

      {/* Készségek */}
      <div>
        <label className="block mt-4 mb-1 font-medium">Készségek</label>
        <input
          value={skills}
          onChange={(e) => setSkills(e.target.value)}
          placeholder="Pl.: JavaScript, React, Node.js"
          className="border p-2 w-full rounded"
        />
      </div>

      {/* Gombok */}
      <div className="flex justify-between mt-4">
        <button
          onClick={onBack}
          className="bg-gray-200 px-4 py-2 rounded hover:bg-gray-300"
        >
          Vissza
        </button>

        <NextButton />

      </div>
    </form>
  );
}
