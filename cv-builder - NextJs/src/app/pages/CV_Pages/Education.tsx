"use client";
import NextButton from "@/app/components/Buttons/NextButton";
import { useForm } from "react-hook-form";

export default function Step2({ onNext, onBack, cvData, setCvData }: any) {
  const { register, handleSubmit, reset } = useForm({
    defaultValues: {
      school: "",
      degree: "",
      startDate: "",
      endDate: "",
    },
  });

  const addEducation = (data: any) => {
    if (!data) return;
    setCvData((prev: any) => ({
      ...prev,
      education: [...(prev.education || []), data],
    }));
    reset();
  };

  const onSubmit = () => {
    onNext();
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <h2 className="text-2xl font-bold text-center text-blue-700 mb-4">
        Tanulmányok
      </h2>

      {Array.isArray(cvData.education) &&
        cvData.education.map((edu, i) => (
          <div key={i} className="p-3 border rounded bg-gray-50 mb-2">
            <div className="font-semibold">{edu.school}</div>
            <div className="text-sm text-gray-700">{edu.degree}</div>
            <div className="text-sm text-gray-500">
              {edu.startDate} – {edu.endDate}
            </div>
          </div>
        ))}

      <input
        {...register("school")}
        placeholder="Iskola neve"
        className="border p-2 w-full rounded mb-2"
      />
      <input
        {...register("degree")}
        placeholder="Végzettség / szak"
        className="border p-2 w-full rounded mb-2"
      />

      <div className="flex gap-4 mb-2">
        <div className="flex flex-col flex-1">
          <label className="text-sm font-medium mb-1 text-gray-700">
            Kezdés
          </label>
          <input
            {...register("startDate")}
            type="date"
            className="border p-2 rounded w-full"
          />
        </div>
        <div className="flex flex-col flex-1">
          <label className="text-sm font-medium mb-1 text-gray-700">Vége</label>
          <input
            {...register("endDate")}
            type="date"
            className="border p-2 rounded w-full"
          />
        </div>
      </div>

      <button
        type="button"
        onClick={handleSubmit(addEducation)}
        className="bg-gray-300 px-3 py-2 rounded hover:bg-gray-400 w-full"
      >
        Hozzáadás
      </button>

      <div className="flex justify-between mt-4">
        <button
          type="button"
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
