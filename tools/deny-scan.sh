#!/bin/sh
# deny-scan: exit 1 and print matches if any input file (or stdin via "-") hits a forbidden pattern.
[ "$#" -ge 1 ] || { echo "usage: deny-scan.sh <file|->..." >&2; exit 2; }
pf=$(mktemp); tmp=$(mktemp)
trap 'rm -f "$pf" "$tmp"' EXIT
cat > "$pf" <<'PATTERNS'
\b([0-9]{1,3}\.){3}[0-9]{1,3}\b
ts\.net
\.home\.[a-z0-9-]+\.[a-z]{2,}
:[0-9]{4,5}\b
vmid
\bct ?[0-9]{3}\b
sha256:
infisical
_TOKEN
_API_KEY
password
github\.com/paletas/[a-z]
[A-Za-z]:\\
€
\bEUR\b
\$[0-9]
youtube\.com
youtu\.be
PATTERNS
[ -n "${DENY_SCAN_EXTRA:-}" ] && [ -f "$DENY_SCAN_EXTRA" ] && cat "$DENY_SCAN_EXTRA" >> "$pf"
rc=0
for f in "$@"; do
  if [ "$f" = "-" ]; then cat > "$tmp"; f="$tmp"; fi
  if grep -nEi -f "$pf" -- "$f"; then rc=1; fi
done
exit $rc
