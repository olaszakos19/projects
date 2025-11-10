import { Page, Text, View, Document, StyleSheet } from "@react-pdf/renderer";

const styles = StyleSheet.create({
  page: {
    padding: 30,
    fontSize: 12,
    fontFamily: "Helvetica",
  },
  header: {
    fontSize: 22,
    marginBottom: 10,
    textAlign: "center",
    color: "#2c3e50",
  },
  section: {
    marginBottom: 15,
  },
  title: {
    fontSize: 14,
    fontWeight: "bold",
    marginBottom: 5,
    color: "#b93f29ff",
  },
  text: {
    marginBottom: 3,
  },
});

export default function Roma({ cvData }: any) {
  return (
    <Document>
      <Page style={styles.page}>
        <Text style={styles.header}>{cvData.personal?.name}</Text>
        <Text style={styles.text}>{cvData.personal?.email}</Text>
        <Text style={styles.text}>{cvData.personal?.phone}</Text>

        <View style={styles.section}>
          <Text style={styles.title}>Összefoglaló</Text>
          <Text>{cvData.personal?.summary}</Text>
        </View>

        <View style={styles.section}>
          <Text style={styles.title}>Tanulmányok</Text>
          {cvData.education?.map((edu: any, i: number) => (
            <Text key={i}>
              {edu.school} — {edu.degree} ({edu.startDate} - {edu.endDate})
            </Text>
          ))}
        </View>

        <View style={styles.section}>
          <Text style={styles.title}>Tapasztalat</Text>
          {cvData.experience?.map((exp: any, i: number) => (
            <Text key={i}>
              {exp.company} — {exp.position} ({exp.startDate} - {exp.endDate})
            </Text>
          ))}
        </View>

        <View style={styles.section}>
          <Text style={styles.title}>Készségek</Text>
          <Text>{cvData.skills?.join(", ")}</Text>
        </View>
      </Page>
    </Document>
  );
}
