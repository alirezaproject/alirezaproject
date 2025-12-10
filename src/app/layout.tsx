import type { Metadata } from "next";
import "./globals.css";
import { Header } from "@/components/Header";
import PageTransition from "@/components/PageTransition";
import StairTransition from "@/components/StairTransition";
import { Toaster } from "react-hot-toast";


export const metadata: Metadata = {
  title: "سایت شخصی علی رضا شکوهیان",
  description: "این سایت شخصی علی رضا شکوهیان است که در آن می توانید با رزومه، نمونه کارها و اطلاعات تماس من آشنا شوید.",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="fa" dir="rtl" className="font-primary bg-primary">
      <body
        className={`antialiased md:max-w-4xl xl:max-w-7xl mx-auto`}
      >
        <Header />
        <StairTransition />
        <PageTransition>
          {children}
          <Toaster position="top-center" />

        </PageTransition>

      </body>
    </html>
  );
}
