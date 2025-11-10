import { jsPDF } from "jspdf";
import { modernTemplate } from "@/app/Templates/modernTemplate";

export const generatePDF = (data: any, template: "modern" | "minimal" | "classic" = "modern") => {
  const doc = new jsPDF();

  switch (template) {
    case "classic":
      // classicTemplate(doc, data);
      break;
    default:
      modernTemplate(doc, data);
  }

  
  
  doc.save(`${data.personal?.name || "resume"}.pdf`);
};
