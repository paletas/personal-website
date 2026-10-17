// Builds the responsive profile image variants (avif + webp at 240/400/680 wide, 4:5).
// Usage: npm run images [-- --src <path>]
// --src defaults to wwwroot/img/profile-960.webp. The 480 and 960 files are kept as committed and never written here.
import fs from 'node:fs';
import path from 'node:path';
import { fileURLToPath } from 'node:url';
import sharp from 'sharp';

const args = process.argv.slice(2);
const arg = (name) => {
  const i = args.indexOf(name);
  return i >= 0 ? args[i + 1] : undefined;
};

const here = path.dirname(fileURLToPath(import.meta.url));
const outDir = path.resolve(here, '../wwwroot/img');
const src = arg('--src') ?? path.resolve(outDir, 'profile-960.webp');
if (!fs.existsSync(src)) {
  console.error(`source image not found: ${src}`);
  process.exit(1);
}

for (const w of [240, 400, 680]) {
  const h = Math.round(w * 1.25);
  await sharp(src).resize(w, h).avif({ quality: 50 }).toFile(path.join(outDir, `profile-${w}.avif`));
  await sharp(src).resize(w, h).webp({ quality: 75 }).toFile(path.join(outDir, `profile-${w}.webp`));
  console.log(`wrote profile-${w}.avif / .webp`);
}
