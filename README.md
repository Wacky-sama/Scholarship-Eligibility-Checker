# Scholarship Eligibility Checker

A simple Windows Forms (VB.NET) app that determines a student’s letter grade and scholarship tier based on GPA, family income, and community service hours.

---

## 📂 Project Structure

- `Scholarship Eligibility Checker.sln` — Solution file  
- `Form1.vb` — Main form with logic for calculating grade & scholarship  
- `Form1.Designer.vb` — UI layout (if using drag-n-drop designer)  
- `.gitignore` / `.gitattributes` — Standard settings  

---

## 🚀 How to Run

1. Clone the repo:
```bash
git clone https://github.com/Wacky-sama/Scholarship-Eligibility-Checker.git
```

3. Open `Scholarship Eligibility Checker.sln` in Visual Studio (or your VB.NET IDE).
4. Build and Run (F5 or Ctrl+F5).
5. Enter values for:
- GPA (decimal)
- Income (numeric)
- Community Hours (integer)
5. Click **Calculate** — it shows:
- **Grade** (A / B / C / D / F)  
- **Scholarship Tier** (Merit Full, Merit Partial, Needs-Based, Ineligible)

---

## ✅ Logic Rules (current version)

- **Letter Grades**  
- ≥ 4.5 → A  
- 4.0 – 4.49 → B  
- 3.0 – 3.99 → C  
- 2.0 – 2.99 → D  
- below 2.0 → F  

- **Scholarship Tiers**  
1. GPA ≥ 4.5 **and** communityHours ≥ 20 → *Merit Full*  
2. GPA ≥ 4.0 **and** communityHours ≥ 10 → *Merit Partial*  
3. income ≤ 2000 → *Needs-Based*  
4. otherwise → *Ineligible*

---

## 🛠️ Possible Improvements / To-Do

- Add **input validation** (e.g. prevent negative numbers, non-numeric input)  
- Use **error messages** per field instead of generic catch-all  
- Enhance UI: nicer layout, labels, tooltips, formatting  
- Save / Load records (CSV or database)  
- Add **unit tests** for MapGpaToLetterGrade & DetermineScholarshipTier  
- Switch to **more flexible grading/scoring rules** (config file / UI options)

---

## 🙋 Contributing

1. Fork the repo  
2. Create a feature branch (`git checkout -b feature/MyFeature`)  
3. Make changes & commit (`git commit -m "Add X"`)  
4. Push and open a Pull Request  
5. I’ll review and merge if all looks good

---
