"use client";
import { useState } from "react";
import { PDFDownloadLink, PDFViewer } from "@react-pdf/renderer";
import ModernTemplate from "@/app/components/pdf/ModernTemplate";
import Roma from "@/app/components/pdf/Roma";
import London from "@/app/components/pdf/London";
import Oklahoma from "@/app/components/pdf/Oklahoma";

const templates = {
  modern: ModernTemplate,
  roma: Roma,
  london: London,
  oklahoma: Oklahoma,
};

export default function TemplateSelector({ cvData }: any) {
  const [selected, setSelected] = useState<string | null>(null);
  const [preview, setPreview] = useState<string | null>(null);

  const SelectedTemplate = selected ? templates[selected] : null;

  function handleSelect(key){
    setPreview("");
    setPreview(key);
  }

  return (
    <div className="p-6 space-y-4">
      <h2 className="text-xl font-bold mb-4">Válaszd ki az önéletrajz sablont</h2>

      {/* === Sablon kártyák === */}
      <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-2 gap-6">
        {Object.keys(templates).map((key) => {
          const Template = templates[key];
          return (
            <div
              key={key}
              onClick={() => handleSelect(key)}
              className={`border rounded-xl overflow-hidden shadow hover:shadow-lg transition cursor-pointer ${
                preview === key ? "ring-2 ring-blue-500" : ""
              }`}
            >
              <div className="bg-gray-100 aspect-[3/4]">
                {/* Kis előnézet 
                
                */}
                <PDFViewer width="100%" height="100%" key={key}>
                  <Template cvData={cvData} />
                </PDFViewer>
              </div>
              <div className="p-3 text-center">
                <p className="font-semibold capitalize">{key} sablon</p>
                <p className="text-sm text-gray-500 mt-1">Kattints a nagyobb előnézethez</p>
              </div>
            </div>
          );
        })}
      </div>

      {/* === Nagy előnézet modál === */}
      {preview && (
        <div className="fixed inset-0 bg-black/70 flex items-center justify-center z-50">
          <div className="bg-white rounded-2xl p-6 max-w-5xl w-full max-h-[90vh] overflow-hidden relative shadow-lg">
            <button
              onClick={() => setPreview(null)}
              className="absolute top-4 right-4 text-gray-600 hover:text-black text-xl"
            >
              ✕
            </button>

            <div className="h-[80vh]">
              <PDFViewer width="100%" height="100%">
                {(() => {
                  const Template = templates[preview];
                  return <Template cvData={cvData} />;
                })()}
              </PDFViewer>
            </div>

            <div className="mt-4 flex justify-end gap-3">
              <button
                onClick={() => {
                  setSelected(preview);
                  setPreview(null);
                }}
                className="bg-blue-600 text-white px-4 py-2 rounded hover:bg-blue-700"
              >
                Kiválasztás
              </button>
            </div>
          </div>
        </div>
      )}

      {/* === PDF Letöltés gomb === */}
      {SelectedTemplate && (
        <div className="mt-6 text-center">
          <PDFDownloadLink
            document={<SelectedTemplate cvData={cvData} />}
            fileName={`${cvData.personal?.name || "cv"}.pdf`}
          >
            {({ loading }) => (
              <button className="bg-green-600 text-white px-6 py-3 rounded-lg hover:bg-green-700">
                {loading ? "PDF generálása..." : "📄 PDF letöltése"}
              </button>
            )}
          </PDFDownloadLink>
        </div>
      )}
    </div>
  );
}
