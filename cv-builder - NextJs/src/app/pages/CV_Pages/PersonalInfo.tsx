"use client";
import { useForm } from "react-hook-form";
import { useState } from "react";
import NextButton from "@/app/components/Buttons/NextButton";

export default function Step1({ onNext, cvData, setCvData }: any) {
  const { register, handleSubmit } = useForm({
    defaultValues: cvData.personal || {},
  });

  const [preview, setPreview] = useState<string | null>(
    cvData.personal?.photo || null
  );

  const onSubmit = (data: any) => {
    setCvData((prev: any) => ({
      ...prev,
      personal: {
        ...data,
        photo: preview, // kép is mentve marad
      },
    }));
    onNext();
  };

  const handleImageChange = (e: any) => {
    const file = e.target.files[0];
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => setPreview(reader.result as string);
      reader.readAsDataURL(file);
    }
  };

  return (
    <form
      onSubmit={handleSubmit(onSubmit)}
      className="max-w-lg mx-auto bg-white shadow-md rounded-2xl p-6 space-y-5"
    >
      <h2 className="text-2xl font-bold text-center text-blue-700 mb-4">
        Személyes adatok
      </h2>

      {/* Kép feltöltése */}
      <div className="flex flex-col items-center space-y-3">
        {preview ? (
          <img
            src={preview}
            alt="Profilkép előnézet"
            className="w-32 h-32 rounded-full object-cover border shadow-sm"
          />
        ) : (
          <div className="w-32 h-32 flex items-center justify-center rounded-full bg-gray-100 border text-gray-400">
            Nincs kép
          </div>
        )}
        <label className="cursor-pointer text-blue-600 font-medium hover:underline">
          Profilkép feltöltése
          <input
            type="file"
            accept="image/*"
            onChange={handleImageChange}
            className="hidden"
          />
        </label>
      </div>

      {/* Név */}
      <div>
        <label className="block text-sm font-medium mb-1 text-gray-700">
          Név
        </label>
        <input
          {...register("name")}
          placeholder="Teljes név"
          className="border border-gray-300 p-2 rounded w-full focus:ring-2 focus:ring-blue-400 outline-none"
        />
      </div>

      {/* Cím, Irányítószám, Város */}
      <div>
        <label className="block text-sm font-medium mb-1 text-gray-700">
          Cím
        </label>
        <input
          {...register("address")}
          placeholder="Utca, házszám"
          className="border border-gray-300 p-2 rounded w-full focus:ring-2 focus:ring-blue-400 outline-none"
        />
      </div>

      <div className="grid grid-cols-2 gap-3">
        <div>
          <label className="block text-sm font-medium mb-1 text-gray-700">
            Irányítószám
          </label>
          <input
            {...register("zip")}
            placeholder="1234"
            className="border border-gray-300 p-2 rounded w-full focus:ring-2 focus:ring-blue-400 outline-none"
          />
        </div>

        <div>
          <label className="block text-sm font-medium mb-1 text-gray-700">
            Város
          </label>
          <input
            {...register("city")}
            placeholder="Budapest"
            className="border border-gray-300 p-2 rounded w-full focus:ring-2 focus:ring-blue-400 outline-none"
          />
        </div>
      </div>

      {/* Telefonszám és email */}
      <div className="grid grid-cols-2 gap-3">
        <div>
          <label className="block text-sm font-medium mb-1 text-gray-700">
            Telefonszám
          </label>
          <input
            {...register("phone")}
            placeholder="+36 30 123 4567"
            className="border border-gray-300 p-2 rounded w-full focus:ring-2 focus:ring-blue-400 outline-none"
          />
        </div>

        <div>
          <label className="block text-sm font-medium mb-1 text-gray-700">
            Email
          </label>
          <input
            {...register("email")}
            type="email"
            placeholder="pelda@email.com"
            className="border border-gray-300 p-2 rounded w-full focus:ring-2 focus:ring-blue-400 outline-none"
          />
        </div>
      </div>

      {/* Összefoglaló */}
      <div>
        <label className="block text-sm font-medium mb-1 text-gray-700">
          Rövid összefoglaló
        </label>
        <textarea
          {...register("summary")}
          placeholder="Írj néhány mondatot magadról, tapasztalataidról vagy céljaidról..."
          className="border border-gray-300 p-2 rounded w-full h-24 resize-none focus:ring-2 focus:ring-blue-400 outline-none"
        />
      </div>

      {/* Tovább gomb */}
      <NextButton />
    </form>
  );
}
